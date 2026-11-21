#pragma warning disable WFO1000 // disabled warnings for this file

namespace Weekly_Planner
{
    public partial class frmMain : Form
    {

        private int _taskCount = 0;
        private int _TotalPlannedTime = 0;
        private int _plannedDays = 0;

        public int TasksCount
        {
            set
            {
                _taskCount = value;
                lblActivitiesCount.Text = _taskCount.ToString();
            }
            get
            {
                return _taskCount;
            }
        }
        public int PlanningDays
        {
            set
            {
                _plannedDays = value;
                lblPlannedDays.Text = "7/" + _plannedDays;
            }
            get
            {
                return _plannedDays;
            }
        }


        ///<summary> Gets or sets the total planned time in minutes </summary>
        public int TotalPlannedTime
        {
            set
            {
                _TotalPlannedTime = value;
                var Time = TimeSpan.FromMinutes(_TotalPlannedTime);
                lblTotalTime.Text =$" يوم {Time.Days} " + $" ساعة {Time.Hours} " + $" دقيقة {Time.Minutes} ";
            }
            get
            {
                return _TotalPlannedTime;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void daysPanel_TaskAdded(object sender, EventArgs e)
        {
            
        }

        private void daysPanel_TaskRemoved(object sender, EventArgs e)
        {
            
        }
    }
}
