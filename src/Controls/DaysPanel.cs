#pragma warning disable WFO1000 // Disable the warning for the file

using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class DaysPanel : FlowLayoutPanel
    {
        // Define a constant for the maximum time per day in minutes (24 hours * 60 = 1440 min)
        private const int MAX_TIME_PER_DAY = 1440;
        private int _tasksCount = 0;

        /// <summary>
        /// Get or set the number of tasks in this DaysPanel.
        /// </summary>
        public int TasksCount
        {
            get =>_tasksCount; 
            // Update the tasksCount field and raise the appropriate event
            set => _tasksCount = value;
        }
        

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


        public event EventHandler ActivityRemoved;
        private void OnActivityRemoved(EventArgs e)
        {
            ActivityRemoved?.Invoke(this, e);
        }

        public event EventHandler ActivityAdded;
        private void OnActivityAdded(EventArgs e)
        {
            ActivityAdded?.Invoke(this, e);
        }

        public event EventHandler ActivityEdited;
        private void OnActivityEdited(EventArgs e)
        {
            ActivityEdited?.Invoke(this, e);
        }


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

            using frmCreateOrEditNote frmCreateActivity = new frmCreateOrEditNote(RemainingTime);
            frmCreateActivity.ActivityCreated += AddActivity;
            frmCreateActivity.ShowDialog();

        }

        public void AddActivity(object? sender, ActivityInfo Activity)
        {
            var newNote = new Note(Activity);

            newNote.UserWannaDeletingNote += RemoveActivity;
            newNote.UserWannaEditingNote += EditActivity;

            this.Controls.Add(newNote);
            TasksCount++;

            // Ensure the "Add New" button is always at the bottom of the panel
            this.Controls.SetChildIndex(btnAddNew, Controls.Count - 1);
            OnActivityAdded(EventArgs.Empty);
        }

        public void EditActivity(object? sender, Note note)
        {      
            using frmCreateOrEditNote frmEditActivity = new frmCreateOrEditNote(RemainingTime + note.Duration, note.Info);            
            frmEditActivity.ShowDialog();
            OnActivityEdited(EventArgs.Empty);

            // Refresh the note to reflect any changes made in the edit form
            note.Refresh();
        }

        public void RemoveActivity(object? sender, Note Note)
        {
            this.Controls.Remove(Note);
            Note.Dispose();
            TasksCount--;
            OnActivityRemoved(EventArgs.Empty);
        }

    }
}