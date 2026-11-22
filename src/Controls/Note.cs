#pragma warning disable WFO1000 // Disable the warning for missing XML comments on public members
using Weekly_Planner.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Controls
{
    public partial class Note : UserControl
    {
        /// <summary>
        /// Event triggered when the user wants to delete the note. The event passes the associated ActivityInfo as an argument.
        /// </summary>
        public event EventHandler<Note> UserWannaDeletingNote;

        private void OnUserWannaDeletingNote(Note activityInfo)
        {
            UserWannaDeletingNote?.Invoke(this, activityInfo);
        }

        /// <summary>
        /// Event triggered when the user wants to edit the note. The event passes the associated ActivityInfo as an argument.
        /// </summary>
        public event EventHandler<Note> UserWannaEditingNote;
        private void OnUserWannaEditingNote(Note activityInfo)
        {
            UserWannaEditingNote?.Invoke(this, activityInfo);
        }

        private readonly ActivityInfo _activityInfo;

        public ActivityInfo Info => _activityInfo;


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

        public Note(ActivityInfo activityInfo)
        {
            InitializeComponent();
            _activityInfo = activityInfo;
            Title = activityInfo.Title;
            Description = activityInfo.Description;
            Duration = activityInfo.Duration;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnUserWannaDeletingNote(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnUserWannaEditingNote(this);
        }
    

        public override void Refresh()
        {
            Title = _activityInfo.Title;
            Description = _activityInfo.Description;
            Duration = _activityInfo.Duration;
            base.Refresh();
        }
    }
}
