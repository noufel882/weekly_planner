#pragma warning disable WFO1000 // Disable the warning for missing XML comments on public members
using Weekly_Planner.Forms;
using Weekly_Planner.Models;
using Weekly_Planner.Properties;

namespace Weekly_Planner.Controls
{
    /// <summary>
    /// Displays a single planned activity and provides edit, delete, and expand controls.
    /// </summary>
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
        /// Gets or sets the duration of the activity in minutes.
        /// </summary>
        /// <value>The duration in minutes.</value>
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
        /// Gets or sets the content of the activity note.
        /// </summary>
        /// <value>The activity description.</value>
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
        /// Gets or sets the title of the activity note.
        /// </summary>
        /// <value>The activity title.</value>
        public string Title
        {
            get { return _activityInfo.Title; }
            set
            {
                _activityInfo.Title = value;
                lblTitle.Text = value;
            }
        }

        private int _expandedHeight;
        
        private bool _isCollapse = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Note"/> class.
        /// </summary>
        /// <param name="activityInfo">The activity to display.</param>
        public Note(ActivityDetails activityInfo)
        {
            InitializeComponent();
            _activityInfo = activityInfo;
            Title = activityInfo.Title;
            Description = activityInfo.Description;
            Duration = activityInfo.Duration;
            _expandedHeight = this.Height;
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
        /// Retrieves the current state of the note as activity details.
        /// </summary>
        /// <returns>A new <see cref="ActivityDetails"/> containing the note's current title, description, and duration.</returns>
        public ActivityDetails ToActivityDetail()
        {
            return new ActivityDetails(this.Title, this.Description, this.Duration);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            using var detailsForm = new frmViewActivityDetails(this.ToActivityDetail());
            detailsForm.ShowDialog();
        }

        private void btnToggleNote_Click(object sender, EventArgs e)
        {
            if (_isCollapse)
                Expand();
            else
                Collapse();

            _isCollapse = !_isCollapse;
        }

        private void Expand()
        {
            btnToggleNote.Image = Resources.arrow_down_36;
            this.Height = _expandedHeight;
        }

        private void Collapse()
        {
            btnToggleNote.Image = Resources.arrow_up_36;
            this.Height = pnlHead.Bottom;
        }
    }
}