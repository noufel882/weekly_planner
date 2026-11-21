#pragma warning disable WFO1000 // Disable the warning for missing XML comments on public members
namespace Weekly_Planner.Controls
{
    public partial class ActivityNote : UserControl
    {
        private int _duration;
        /// <summary>
        /// get or set the duration of the activity in minutes.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                lblDuration.Text = _duration.ToString();
            }
        }

        /// <summary>
        /// Get or set the content of the activity note.
        /// </summary>
        public string Content
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }
        /// <summary>
        /// Get or set the title of the activity note.
        /// </summary>
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public ActivityNote()
        {
            InitializeComponent();
        }

        public ActivityNote(string title, string content, int duration)
        {
            InitializeComponent();
            Title = title;
            Content = content;
            Duration = duration;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.Parent is DaysPanel daysPanel)
            {
                daysPanel.RemoveActivity(this);
            }
        }

    }
}
