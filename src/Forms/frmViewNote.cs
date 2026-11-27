using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    /// <summary>
    /// Displays the complete details of a planned activity.
    /// </summary>
    public partial class frmViewActivityDetails : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmViewActivityDetails"/> class.
        /// </summary>
        /// <param name="note">The activity details to display.</param>
        public frmViewActivityDetails(ActivityDetails note)
        {
            InitializeComponent();
            txtTitle.Text = note.Title;
            txtDescription.Text = note.Description;
            txtDuration.Text = note.Duration.ToString();
        }

        /// <summary>
        /// Closes the activity details form.
        /// </summary>
        /// <param name="sender">The close button that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnClose_Click(object sender, EventArgs e) => Close();

    }
}
