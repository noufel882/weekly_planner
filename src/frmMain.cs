#pragma warning disable WFO1000 // disabled warnings for this file

using Weekly_Planner.Controls;

namespace Weekly_Planner
{
    public partial class frmMain : Form
    {
        private int _taskCount = 0;
        private int _totalPlannedTime = 0;
        private int _plannedDays = 0;

        public int TasksCount
        {
            get => _taskCount;
            set
            {
                _taskCount = value;
                lblActivitiesCount.Text = _taskCount.ToString();
            }
        }
        public int PlanningDays
        {
            get => _plannedDays;
            set
            {
                _plannedDays = value;
                lblPlannedDays.Text = "7/" + _plannedDays;
            }
        }

        ///<summary> Gets or sets the total planned time in minutes </summary>
        public int TotalPlannedTime
        {
            set
            {
                _totalPlannedTime = value;
                var time = TimeSpan.FromMinutes(_totalPlannedTime);
                lblTotalTime.Text = $" يوم {time.Days} " + $" ساعة {time.Hours} " + $" دقيقة {time.Minutes} ";
            }
            get
            {
                return _totalPlannedTime;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            TasksCount = 0;
            TotalPlannedTime = 0;
            PlanningDays = 0;
        }

        private void daysPanel_TaskAdded(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void daysPanel_TaskRemoved(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {      
            int plannedDays = 0;
            int totalPlannedTime = 0;
            int taskCount = 0;

            foreach (var dayPanel in tlpDaysTable.Controls.OfType<DaysPanel>())
            {
                if (dayPanel.TasksCount > 0)
                {
                    plannedDays++;
                    taskCount += dayPanel.TasksCount;
                    totalPlannedTime += dayPanel.TotalPlannedTime;
                }
            }

            // Update the UI labels with the new values
            PlanningDays = plannedDays;
            TotalPlannedTime = totalPlannedTime;
            TasksCount = taskCount;

        }
      
    }
}