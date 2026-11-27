namespace Weekly_Planner.Forms
{
    partial class frmCreateOrEditActivity
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
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(452, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(143, 34);
            label1.TabIndex = 0;
            label1.Text = "العنوان :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(454, 126);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(145, 34);
            label2.TabIndex = 1;
            label2.Text = "المحتوى :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(376, 576);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(215, 34);
            label3.TabIndex = 2;
            label3.Text = "المدة (دقائق) :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(27, 44, 66);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Tahoma", 13F);
            txtTitle.ForeColor = Color.Silver;
            txtTitle.Location = new Point(22, 58);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(555, 32);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(27, 44, 66);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Tahoma", 13F);
            txtDescription.ForeColor = Color.Silver;
            txtDescription.Location = new Point(24, 172);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(551, 376);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(79, 209, 197);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.FromArgb(13, 19, 31);
            btnConfirm.Location = new Point(24, 621);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(89, 47);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "تأكيد";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // nudDuration
            // 
            nudDuration.BackColor = Color.FromArgb(27, 44, 66);
            nudDuration.BorderStyle = BorderStyle.None;
            nudDuration.Font = new Font("Tahoma", 13F);
            nudDuration.ForeColor = Color.Silver;
            nudDuration.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Location = new Point(181, 576);
            nudDuration.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(180, 35);
            nudDuration.TabIndex = 6;
            nudDuration.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(27, 44, 66);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Tahoma", 10F);
            btnClose.ForeColor = Color.FromArgb(79, 209, 197);
            btnClose.Location = new Point(136, 621);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 47);
            btnClose.TabIndex = 7;
            btnClose.Text = "خروج";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmCreateOrEditActivity
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(604, 674);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(nudDuration);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateOrEditActivity";
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
        private Button btnClose;
    }
}