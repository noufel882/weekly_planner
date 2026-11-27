namespace Weekly_Planner.Forms
{
    partial class frmViewActivityDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDescription = new RichTextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDuration = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(27, 44, 66);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Tahoma", 13F);
            txtDescription.ForeColor = Color.Silver;
            txtDescription.Location = new Point(14, 170);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(551, 376);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(27, 44, 66);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Tahoma", 13F);
            txtTitle.ForeColor = Color.Silver;
            txtTitle.Location = new Point(12, 56);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(555, 32);
            txtTitle.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(354, 574);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(215, 34);
            label3.TabIndex = 10;
            label3.Text = "المدة (دقائق) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(420, 124);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(145, 34);
            label2.TabIndex = 9;
            label2.Text = "المحتوى :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(421, 13);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(143, 34);
            label1.TabIndex = 8;
            label1.Text = "العنوان :  ";
            // 
            // txtDuration
            // 
            txtDuration.BackColor = Color.FromArgb(27, 44, 66);
            txtDuration.BorderStyle = BorderStyle.None;
            txtDuration.Font = new Font("Segoe UI", 13F);
            txtDuration.ForeColor = Color.Silver;
            txtDuration.Location = new Point(158, 572);
            txtDuration.Name = "txtDuration";
            txtDuration.ReadOnly = true;
            txtDuration.Size = new Size(180, 35);
            txtDuration.TabIndex = 16;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(27, 44, 66);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Tahoma", 10F);
            btnClose.ForeColor = Color.FromArgb(79, 209, 197);
            btnClose.Location = new Point(14, 627);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 47);
            btnClose.TabIndex = 18;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmViewActivityDetails
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(576, 682);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(txtDuration);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmViewActivityDetails";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تفاصيل النشاط";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txtDescription;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDuration;
        private Button btnClose;
    }
}