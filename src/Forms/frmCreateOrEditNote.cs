#pragma warning disable WFO1000 // disabled warnings for this file
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    public partial class frmCreateOrEditNote : Form
    {

        public enum Mode { Create , Edit}

        private Mode _currentMode;

        ///<summary> Get or set the current mode of the form , which can be either Create or Edit.</summary>
        public Mode CurrentMode
        {
            get { return _currentMode; }
            set
            {
                _currentMode = value;
                if (_currentMode == Mode.Create)
                {
                    this.Text = "إضافة نشاط";
                }
                else if (_currentMode == Mode.Edit)
                {
                    this.Text = "تعديل النشاط";
                }
            }
        }
        
        private ActivityInfo _activityInfo;

        /// <summary>
        /// The event that is raised when a new activity is created.
        /// </summary>
        public event EventHandler<ActivityInfo> ActivityCreated;

        private void OnActivityCreated(ActivityInfo activityInfo)
        {
            ActivityCreated?.Invoke(this, activityInfo);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateOrEditNote"/> class.
        /// </summary>
        /// <param name="AvailableTimeInMinutes">The maximum time available for the activity in minutes.</param>
        public frmCreateOrEditNote(int AvailableTimeInMinutes)
        {
            InitializeComponent();
            CurrentMode = Mode.Create;
            nudDuration.Maximum = AvailableTimeInMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateOrEditNote"/> class.
        /// </summary>
        /// <param name="AvailableTimeInMinutes">The maximum time available for the activity in minutes.</param>
        /// <param name="activityInfo">An object containing the activity information to edit.</param>
        public frmCreateOrEditNote(int AvailableTimeInMinutes,ActivityInfo activityInfo)
        {
            InitializeComponent();
            CurrentMode = Mode.Edit;
            _activityInfo = activityInfo;
            txtTitle.Text = activityInfo.Title;
            txtDescription.Text = activityInfo.Description;
            nudDuration.Value = activityInfo.Duration;
            nudDuration.Maximum = AvailableTimeInMinutes;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("ادخال اسم النشاط");
                return;
            }


            if (CurrentMode == Mode.Create)
            {
                _activityInfo = new ActivityInfo(txtTitle.Text ,txtDescription.Text, (int)nudDuration.Value);
            
                OnActivityCreated(_activityInfo);
                // disable the button to prevent multiple clicks
                this.btnConfirm.Enabled = false;
            }

            else// Edit mode
            {
                _activityInfo.Title = txtTitle.Text;
                _activityInfo.Description = txtDescription.Text;
                _activityInfo.Duration = (int)nudDuration.Value;           
            }


            MessageBox.Show("تمت العملية بنجاح");
            
        }

    }
}