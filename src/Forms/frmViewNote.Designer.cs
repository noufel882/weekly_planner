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
            btnClose = new Button();
            nudDuration = new NumericUpDown();
            txtDescription = new RichTextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(23, 28, 52);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(35, 642);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 47);
            btnClose.TabIndex = 15;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(34, 28, 52);
            nudDuration.ForeColor = Color.White;
            nudDuration.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Location = new Point(227, 582);
            nudDuration.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.ReadOnly = true;
            nudDuration.Size = new Size(180, 31);
            nudDuration.TabIndex = 14;
            nudDuration.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(34, 28, 52);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(18, 178);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(563, 376);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(34, 28, 52);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(18, 64);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(563, 31);
            txtTitle.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(429, 581);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(161, 32);
            label3.TabIndex = 10;
            label3.Text = "المدة (دقائق) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(482, 134);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(108, 32);
            label2.TabIndex = 9;
            label2.Text = "المحتوى :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(478, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(112, 32);
            label1.TabIndex = 8;
            label1.Text = "العنوان :  ";
            // 
            // frmViewActivityDetails
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(600, 706);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(nudDuration);
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
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private NumericUpDown nudDuration;
        private RichTextBox txtDescription;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}