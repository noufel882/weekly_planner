using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Weekly_Planner.Controls;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    public partial class frmViewActivityDetails : Form
    {
        public frmViewActivityDetails(ActivityDetails note)
        {
            InitializeComponent();
            txtTitle.Text = note.Title;
            txtDescription.Text = note.Description;
            nudDuration.Value = note.Duration;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
