#pragma warning disable WFO1000 // disabled warnings for this file
using System.Diagnostics.Eventing.Reader;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    public partial class frmCreateOrEditActivity : Form
    {

        public enum Mode { Create, Edit }

        private Mode _currentMode;

        ///<summary> Get or set the current mode of the form , which can be either Create or Edit.</summary>

        private ActivityDetails _Activity;

        public ActivityDetails Activity => _Activity;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateOrEditActivity"/> class.
        /// </summary>
        /// <param name="AvailableTimeInMinutes">The maximum time available for the activity in minutes.</param>
        public frmCreateOrEditActivity(int AvailableTimeInMinutes)
        {
            InitializeComponent();
            this.Text = "إضافة نشاط";
            _currentMode = Mode.Create;
            nudDuration.Maximum = AvailableTimeInMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmCreateOrEditActivity"/> class.
        /// </summary>
        /// <param name="AvailableTimeInMinutes">The maximum time available for the activity in minutes.</param>
        /// <param name="activityInfo">An object containing the activity information to edit.</param>
        public frmCreateOrEditActivity(int AvailableTimeInMinutes, ActivityDetails activityInfo)
        {
            InitializeComponent();
            this.Text = "تعديل النشاط";
            _currentMode = Mode.Edit;
            _Activity = new ActivityDetails(activityInfo.Title, activityInfo.Description, activityInfo.Duration);
            txtTitle.Text = activityInfo.Title;
            txtDescription.Text = activityInfo.Description;
            nudDuration.Value = activityInfo.Duration;
            nudDuration.Maximum = AvailableTimeInMinutes;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("ادخال اسم النشاط");
                return;
            }

            if (_currentMode == Mode.Create)
            {
                _Activity = new ActivityDetails(txtTitle.Text, txtDescription.Text, (int)nudDuration.Value);

                DialogResult = DialogResult.OK;
            }

            // Edit mode
            else if (_currentMode == Mode.Edit) 
            {
                _Activity.Title = txtTitle.Text;
                _Activity.Description = txtDescription.Text;
                _Activity.Duration = (int)nudDuration.Value;
                DialogResult = DialogResult.OK;
            }
            MessageBox.Show("تمت العملية بنجاح");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to Cancel to indicate that the operation was canceled
            // This will close the form and return control to the calling code
            this.DialogResult = DialogResult.Cancel;            
        }
    }
}