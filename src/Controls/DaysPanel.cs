#pragma warning disable WFO1000 // Disable the warning for the file

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

        private void CreateNewActivity(EventArgs e)
        {
            //sample data for testing
            var newActivity = new ActivityNote("عنوان النشاط", "محتوى النشاط", 60)
            {
                Margin = new Padding(0, 3, 0, 3),
            };

            this.Controls.Add(newActivity);
            // Set "Add New" button at the tail of the controls collection
            this.Controls.SetChildIndex(btnAddNew, this.Controls.Count - 1);
            TasksCount++;

        }

        public void RemoveActivity(ActivityNote Activity)
        {
            if (this.Controls.Contains(Activity))
            {
                this.Controls.Remove(Activity);
                TasksCount--;         
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
