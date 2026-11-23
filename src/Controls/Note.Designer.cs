namespace Weekly_Planner.Controls
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            lblTitle = new Label();
            btnDelete = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            lblDuration = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnViewDetails = new Button();
            btnEdit = new Button();
            panel3 = new Panel();
            lblDescription = new Label();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "title";
            // 
            // btnDelete
            // 
            btnDelete.AccessibleDescription = "";
            btnDelete.BackColor = Color.FromArgb(34, 28, 52);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(18, -2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 36);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblTitle);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(230, 38);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lblDuration);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 166);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(230, 31);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(161, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "المدة : ";
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.Gray;
            lblDuration.Location = new Point(133, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(22, 25);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(73, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "دقيقة";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewDetails);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 39);
            panel1.TabIndex = 6;
            // 
            // btnViewDetails
            // 
            btnViewDetails.AccessibleDescription = "";
            btnViewDetails.BackColor = Color.FromArgb(34, 28, 52);
            btnViewDetails.Image = (Image)resources.GetObject("btnViewDetails.Image");
            btnViewDetails.Location = new Point(172, -2);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(36, 36);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnEdit
            // 
            btnEdit.AccessibleDescription = "";
            btnEdit.BackColor = Color.FromArgb(34, 28, 52);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(95, -2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 36);
            btnEdit.TabIndex = 3;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 28, 52);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblDescription);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 128);
            panel3.TabIndex = 7;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(3, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(72, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "content";
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(34, 28, 52);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Margin = new Padding(0, 1, 0, 1);
            Name = "Note";
            Size = new Size(230, 236);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnDelete;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label lblDuration;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label lblDescription;
        private Button btnViewDetails;
        private Button btnEdit;
    }
}
