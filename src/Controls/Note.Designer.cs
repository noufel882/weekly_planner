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
            lblDescription = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDuration = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            panel3 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 45);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblDuration);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(97, 7);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(116, 31);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuration.AutoSize = true;
            lblDuration.ForeColor = Color.Gray;
            lblDuration.Location = new Point(91, 0);
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
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "دقيقة";
            // 
            // btnDelete
            // 
            btnDelete.AccessibleDescription = "حذف";
            btnDelete.BackColor = Color.FromArgb(34, 28, 52);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(6, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 36);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.AccessibleDescription = "تعديل";
            btnEdit.BackColor = Color.FromArgb(34, 28, 52);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(55, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 36);
            btnEdit.TabIndex = 3;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 34, 28, 52);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblDescription);
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 111);
            panel3.TabIndex = 4;
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
            // Note
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(34, 28, 52);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(0, 1, 0, 1);
            Name = "Note";
            Size = new Size(230, 200);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Panel panel2;
        private Label lblDuration;
        private Panel panel3;
        private Button btnEdit;
        private Button btnDelete;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
