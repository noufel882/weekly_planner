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
            nudDuration.Value = note.Duration;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
