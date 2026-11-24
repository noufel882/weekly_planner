 // Disable the warning for the file

using System.ComponentModel;
using Weekly_Planner.Forms;
using Weekly_Planner.Models;
namespace Weekly_Planner.Controls
{
    /// <summary>
    /// Hosts and manages the activity notes for one day of the week.
    /// </summary>
    public partial class DaysPanel : FlowLayoutPanel
    {
        // Define a constant for the maximum time per day in minutes (24 hours * 60 = 1440 min)
        private const int MAX_TIME_PER_DAY = 1440;
        /// <summary>
        /// Gets or sets the number of tasks in this day panel.
        /// </summary>
        /// <value>The number of activity notes.</value>
        public int TasksCount { get; private set; } = 0;

        /// <summary>
        /// Gets the total planned time in minutes for all activities in this day panel.
        /// </summary>
        /// <value>The sum of all activity durations.</value>
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
        /// Gets the remaining time in minutes after accounting for all planned activities.
        /// </summary>
        /// <value>A value between zero and the maximum minutes in a day.</value>
        public int RemainingTime => MAX_TIME_PER_DAY - TotalPlannedTime;

        /// <summary>
        /// Occurs after an activity is added, edited, removed, or loaded.
        /// </summary>
        public event EventHandler? ActivityChanged;

        /// <summary>
        /// Gets or sets the day represented by this panel.
        /// </summary>
        /// <value>The day name.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DayName DayName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DaysPanel"/> class.
        /// </summary>
        public DaysPanel()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Opens the activity creation form and adds a valid activity to the panel.
        /// </summary>
        /// <param name="sender">The add button that raised the event.</param>
        /// <param name="e">The event data.</param>
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

        /// <summary>
        /// Creates and attaches a note for an activity.
        /// </summary>
        /// <param name="activity">The activity to add.</param>
        private void Add(ActivityDetails activity)
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

        /// <summary>
        /// Opens the edit form and applies the submitted changes to an activity note.
        /// </summary>
        /// <param name="sender">The note requesting an edit.</param>
        /// <param name="e">The event data.</param>
        private void Edit(object? sender, EventArgs e)
        {
            var note = (Note)sender!;

            using var frmEditActivity = new frmCreateOrEditActivity(RemainingTime + note.Duration, note.ToActivityDetail());
            
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

        /// <summary>
        /// Removes an activity note from the panel.
        /// </summary>
        /// <param name="sender">The note requesting removal.</param>
        /// <param name="e">The event data.</param>
        private void Remove(object? sender, EventArgs e)
        {
            var note = (Note)sender!;
            this.Controls.Remove(note);
            note.Dispose();
            TasksCount--;
            this.ActivityChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Converts the panel's current notes into a serializable day plan.
        /// </summary>
        /// <returns>A <see cref="PlannerDay"/> containing the panel's activities.</returns>
        public PlannerDay ToPlannerDay()
        {
            var activities = new List<ActivityDetails>();
            foreach (var item in this.Controls)
            {
                if(item is Note note)
                {
                    activities.Add(note.ToActivityDetail());
                }
            }
            return new(this.DayName,activities.ToArray());
        }
    
        /// <summary>
        /// Adds all activities from a serialized day plan to this panel.
        /// </summary>
        /// <param name="day">The day plan to load.</param>
        public void Load(PlannerDay day)
        {
            foreach(var activity in day.ActivitiesList)
            {
                Add(activity);
            }
        }
    }
}