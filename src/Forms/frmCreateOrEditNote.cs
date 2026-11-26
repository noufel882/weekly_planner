#pragma warning disable WFO1000 // disabled warnings for this file
using System.Diagnostics.Eventing.Reader;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    /// <summary>
    /// Provides a form for creating or editing a planned activity.
    /// </summary>
    public partial class frmCreateOrEditActivity : Form
    {

        /// <summary>
        /// Specifies whether the form creates or edits an activity.
        /// </summary>
        public enum Mode
        {
            /// <summary>Creates a new activity.</summary>
            Create,
            /// <summary>Edits an existing activity.</summary>
            Edit
        }

        private Mode _currentMode;

        private ActivityDetails _Activity;

        /// <summary>
        /// Gets the activity currently represented by the form.
        /// </summary>
        /// <value>The activity being created or edited.</value>
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
            _Activity = new ActivityDetails(string.Empty, string.Empty, 0);
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

        /// <summary>
        /// Validates the entered activity data and confirms the create or edit operation.
        /// </summary>
        /// <param name="sender">The confirmation button that raised the event.</param>
        /// <param name="e">The event data.</param>
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
                if (_Activity.Title == txtTitle.Text && _Activity.Description == txtDescription.Text && _Activity.Duration == (int)nudDuration.Value)
                {
                    MessageBox.Show("أنت لم تقم باي تعديل على النشاط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

                _Activity.Title = txtTitle.Text;
                _Activity.Description = txtDescription.Text;
                _Activity.Duration = (int)nudDuration.Value;
                DialogResult = DialogResult.OK;
            }
            MessageBox.Show("تمت العملية بنجاح");

        }

        /// <summary>
        /// Closes the activity form without confirming changes.
        /// </summary>
        /// <param name="sender">The close button that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}