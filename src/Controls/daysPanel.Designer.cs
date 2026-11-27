namespace Weekly_Planner.Controls
{
    partial class DayPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.SuspendLayout();

        
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoScroll = true;

            //btnAddNew////////////////////////////////////////////////////////////
            btnAddNew = new Button();
            btnAddNew.Margin = new Padding(0, 3, 0, 3);
            btnAddNew.Size = new Size(230, 75);
            btnAddNew.Text = "إضافة نشاط";
            btnAddNew.BackColor = Color.FromArgb(27, 44, 66);
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.ForeColor = Color.FromArgb(79, 209, 197);
            btnAddNew.Font = new Font("Tahoma", 12, FontStyle.Bold);
            btnAddNew.Click += btnAddNew_Click;
            ///////////////////////////////////////////////////////////////////////
            this.Padding = new Padding(0, 3, 0,3);
            this.Controls.Add(btnAddNew);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private Button btnAddNew;
        #endregion


    }
}
