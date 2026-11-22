#pragma warning disable WFO1000 // Disable the warning for the file

using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class DaysPanel : FlowLayoutPanel
    {
        private int tasksCount = 0;

        public int TasksCount
        {
            get { return tasksCount; }
            set {
                // Update the tasksCount field and raise the appropriate event
                tasksCount = value;

                // Raise the TaskAdded or TaskRemoved event based on the new value
                if (value > 0)
                    OnActivityAdded(EventArgs.Empty);
                else
                    OnActivityRemoved(EventArgs.Empty);

            }
        }
        
        public event EventHandler ActivityAdded;
        public event EventHandler ActivityRemoved;

        private void OnActivityRemoved(EventArgs e)
        {
            ActivityRemoved?.Invoke(this, e);
        }

        private void OnActivityAdded(EventArgs e)
        {
            ActivityAdded?.Invoke(this, e);
        }

        public DaysPanel()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using frmCreateOrEditActivity frmCreateActivity = new frmCreateOrEditActivity();
            frmCreateActivity.ActivityCreated += AddActivity;
            frmCreateActivity.ShowDialog();

        }

        public void AddActivity(object? sender, ActivityInfo Activity)
        {
            this.Controls.Add(new ActivityNote(Activity));
            TasksCount++;

            // Ensure the "Add New" button is always at the bottom of the panel
            this.Controls.SetChildIndex(btnAddNew, Controls.Count - 1);

        }

        //Note :
        //Do this proccess done through event to avoid the circular reference between DaysPanel and ActivityNote.
        //
        public void RemoveActivity(ActivityNote Note)
        {
            if (this.Controls.Contains(Note))
            {
                this.Controls.Remove(Note);
                Note.Dispose();
                TasksCount--;         
            }
        }

    }
}