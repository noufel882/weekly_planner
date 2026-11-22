using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Weekly_Planner.Models;

namespace Weekly_Planner.Forms
{
    public partial class frmCreateActivity : Form
    {
        private ActivityInfo _activityInfo;

        public event EventHandler<ActivityInfo> ActivityCreated;

        private void OnActivityCreated(ActivityInfo activityInfo)
        {
            ActivityCreated?.Invoke(this, activityInfo);
        }

        public frmCreateActivity()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("ادخال اسم النشاط");
                return;
            }

            if(nudDuration.Value <= 0)
            {
                MessageBox.Show("ادخال مدة النشاط");
                return;
            }

            _activityInfo = new ActivityInfo
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Duration = (int)nudDuration.Value
            };

            MessageBox.Show("تم اضافة النشاط بنجاح");
            OnActivityCreated(_activityInfo);
            Close();

        }
    
        public ActivityInfo GetActivityInfo()
        {
            return _activityInfo;
        }

    }
}
