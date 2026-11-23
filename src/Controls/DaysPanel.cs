#pragma warning disable WFO1000 // Disable the warning for the file

using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class DaysPanel : FlowLayoutPanel
    {
        // Define a constant for the maximum time per day in minutes (24 hours * 60 = 1440 min)
        private const int MAX_TIME_PER_DAY = 1440;
        /// <summary>
        /// Get or set the number of tasks in this DaysPanel.
        /// </summary>
        public int TasksCount { get; private set; } = 0;

        /// <summary>
        /// Get the total planned time in minutes for all activities in this DaysPanel.
        /// </summary>
        public int TotalPlannedTime
        {
            get
            {
                int totalTime = 0;
                foreach (Control control in this.Controls)
                {
                    if (control is Note activityNote)
                    {
                        totalTime += activityNote.Duration;
                    }
                }
                return totalTime;
            }
        }

        /// <summary>
        /// Get the remaining time in minutes for the day after accounting for all planned activities
        /// </summary>
        public int RemainingTime => MAX_TIME_PER_DAY - TotalPlannedTime;

        public event EventHandler? ActivityChanged;

        public DaysPanel()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(RemainingTime <= 0)
            {
                MessageBox.Show("لقد وصلت للحد الأقصى للوقت المخصص اليوم", "المس العشب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var frmCreateActivity = new frmCreateOrEditActivity(RemainingTime);

            // If the user canceled the creation of a new activity, exit the method
            if (frmCreateActivity.ShowDialog() == DialogResult.Cancel)
                return;
            // Otherwise, if the user created a new activity, add it to the pane
            if (frmCreateActivity.Activity is not null)
                Add(frmCreateActivity.Activity);

        }

        private void Add(ActivityInfo activity)
        {
            var newNote = new Note(activity);

            newNote.DeleteRequest += Remove;
            newNote.EditRequest += Edit;

            this.Controls.Add(newNote);
            TasksCount++;

            // Ensure the "Add New" button is always at the bottom of the panel
            this.Controls.SetChildIndex(btnAddNew, Controls.Count - 1);
            this.ActivityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Edit(object? sender, EventArgs e)
        {
            var note = (Note)sender!;

            using var frmEditActivity = new frmCreateOrEditActivity(RemainingTime + note.Duration, note.ToActivityInfo());
            
            // If the user canceled the edit operation, exit the method
            if (frmEditActivity.ShowDialog() != DialogResult.OK)
                return;
        
            //Otherwise, refresh the note to reflect the changes
            note.Title = frmEditActivity.Activity.Title;
            note.Description = frmEditActivity.Activity.Description;
            note.Duration = frmEditActivity.Activity.Duration;
            // Raise the ActivityChanged event for the DaysPanel
            this.ActivityChanged?.Invoke(this, EventArgs.Empty);

        }

        private void Remove(object? sender, EventArgs e)
        {
            var note = (Note)sender!;
            this.Controls.Remove(note);
            note.Dispose();
            TasksCount--;
            this.ActivityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}