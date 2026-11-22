namespace Weekly_Planner.Forms
{
    partial class frmCreateActivity
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            btnConfirm = new Button();
            nudDuration = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(479, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(112, 32);
            label1.TabIndex = 0;
            label1.Text = "العنوان :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(483, 128);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(108, 32);
            label2.TabIndex = 1;
            label2.Text = "المحتوى :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(430, 575);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(161, 32);
            label3.TabIndex = 2;
            label3.Text = "المدة (دقايق) :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(34, 28, 52);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(19, 58);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(563, 31);
            txtTitle.TabIndex = 3;
            // 
            // txtContent
            // 
            txtDescription.BackColor = Color.FromArgb(34, 28, 52);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(19, 172);
            txtDescription.Name = "txtContent";
            txtDescription.Size = new Size(563, 376);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(23, 28, 52);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(38, 632);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(89, 47);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "تأكيد";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(34, 28, 52);
            nudDuration.ForeColor = Color.White;
            nudDuration.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Location = new Point(228, 576);
            nudDuration.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(180, 31);
            nudDuration.TabIndex = 6;
            nudDuration.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // frmCreateActivity
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(608, 714);
            Controls.Add(nudDuration);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmCreateActivity";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة نشاط";
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private Button btnConfirm;
        private NumericUpDown nudDuration;
    }
}