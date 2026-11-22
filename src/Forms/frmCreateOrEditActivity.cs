#pragma warning disable WFO1000 // disabled warnings for this file
using System.Diagnostics;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    public partial class frmCreateOrEditActivity : Form
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
                    txtTitle.Text = _activityInfo.Title;
                    txtDescription.Text = _activityInfo.Description;
                    nudDuration.Value = _activityInfo.Duration;
                }
            }
        }
        
        private ActivityInfo _activityInfo;

        public event EventHandler<ActivityInfo> ActivityCreated;

        private void OnActivityCreated(ActivityInfo activityInfo)
        {
            ActivityCreated?.Invoke(this, activityInfo);
        }

        public frmCreateOrEditActivity()
        {
            InitializeComponent();
            CurrentMode = Mode.Create;
        }

        public frmCreateOrEditActivity(ActivityInfo activityInfo)
        {
            InitializeComponent();
            CurrentMode = Mode.Edit;
            _activityInfo = activityInfo;
            
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

                _activityInfo = new ActivityInfo
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Duration = (int)nudDuration.Value
                };

                OnActivityCreated(_activityInfo);
                // disable the button to prevent multiple clicks
                this.btnConfirm.Enabled = false;
            }

            else
            {
                _activityInfo.Title = txtTitle.Text;
                _activityInfo.Description = txtDescription.Text;
                _activityInfo.Duration = (int)nudDuration.Value;           
            }


            MessageBox.Show("تمت العملية بنجاح");
            
        }
    
        public ActivityInfo GetActivityInfo()
        {
            return _activityInfo;
        }

    }
}