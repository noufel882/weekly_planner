#pragma warning disable WFO1000 // Disable the warning for missing XML comments on public members
using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class ActivityNote : UserControl
    {
        /// <summary>
        /// Represents the activity information associated with this note.
        /// </summary>
        private readonly ActivityInfo _activityInfo;


        /// <summary>
        /// get or set the duration of the activity in minutes.
        /// </summary>
        public int Duration
        {
            get { return _activityInfo.Duration; }
            set
            {
                _activityInfo.Duration = value;
                lblDuration.Text = _activityInfo.Duration.ToString();
            }
        }

        /// <summary>
        /// Get or set the content of the activity note.
        /// </summary>
        public string Description
        {
            get { return _activityInfo.Description; }
            set
            {
                _activityInfo.Description = value;
                lblDescription.Text = value;
            }
        }
        /// <summary>
        /// Get or set the title of the activity note.
        /// </summary>
        public string Title
        {
            get { return _activityInfo.Title; }
            set
            {
                _activityInfo.Title = value;
                lblTitle.Text = value;
            }
        }

        public ActivityNote(ActivityInfo activityInfo)
        {
            InitializeComponent();
            _activityInfo = activityInfo;
            Title = activityInfo.Title;
            Description = activityInfo.Description;
            Duration = activityInfo.Duration;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.Parent is DaysPanel daysPanel)
            {
                daysPanel.RemoveActivity(this);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using(var editForm = new frmCreateOrEditActivity(_activityInfo))
            {
                editForm.ShowDialog();
            }

            
            // Update the activity note with the edited information
            Title = _activityInfo.Title;
            Description = _activityInfo.Description;
            Duration = _activityInfo.Duration;
        }
    
    }
}
