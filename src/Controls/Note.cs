#pragma warning disable WFO1000 // Disable the warning for missing XML comments on public members
using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class Note : UserControl
    {
        /// <summary>
        /// Event triggered when the user wants to delete the note.
        /// </summary>
        public event EventHandler? DeleteRequest;

        /// <summary>
        /// Event triggered when the user wants to edit the note.
        /// </summary>
        public event EventHandler? EditRequest;

        private ActivityDetails _activityInfo;


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

        public Note(ActivityDetails activityInfo)
        {
            InitializeComponent();
            _activityInfo = activityInfo;
            Title = activityInfo.Title;
            Description = activityInfo.Description;
            Duration = activityInfo.Duration;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRequest?.Invoke(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditRequest?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Retrieves the current state of the Note as an ActivityInfo object.
        /// </summary>
        /// <returns></returns>
        public ActivityDetails ToActivityDetail()
        {
            return new ActivityDetails(this.Title, this.Description, this.Duration);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            using var detailsForm = new frmViewActivityDetails(this.ToActivityDetail());
            detailsForm.ShowDialog();
        }
    }
}
