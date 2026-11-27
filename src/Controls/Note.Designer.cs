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
            pnlHead = new Panel();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnToggleNote = new Button();
            lblDescription = new Label();
            btnViewDetails = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pnlTimeInfo = new FlowLayoutPanel();
            label2 = new Label();
            lblDuration = new Label();
            label1 = new Label();
            pnlBody = new Panel();
            pnlContent = new Panel();
            pnlChoiceButtons = new Panel();
            pnlHead.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlTimeInfo.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlChoiceButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.Controls.Add(pnlTitle);
            pnlHead.Controls.Add(btnToggleNote);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(226, 38);
            pnlHead.TabIndex = 9;
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Fill;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(184, 38);
            pnlTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 10F);
            lblTitle.ForeColor = Color.Silver;
            lblTitle.Location = new Point(9, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "title";
            // 
            // btnToggleNote
            // 
            btnToggleNote.AccessibleDescription = "";
            btnToggleNote.BackColor = Color.FromArgb(34, 28, 52);
            btnToggleNote.Dock = DockStyle.Right;
            btnToggleNote.Image = Properties.Resources.arrow_down_36;
            btnToggleNote.Location = new Point(184, 0);
            btnToggleNote.Name = "btnToggleNote";
            btnToggleNote.Size = new Size(42, 38);
            btnToggleNote.TabIndex = 6;
            btnToggleNote.UseVisualStyleBackColor = false;
            btnToggleNote.Click += btnToggleNote_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 10F);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(3, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(77, 24);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "content";
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
            // pnlTimeInfo
            // 
            pnlTimeInfo.Controls.Add(label2);
            pnlTimeInfo.Controls.Add(lblDuration);
            pnlTimeInfo.Controls.Add(label1);
            pnlTimeInfo.Dock = DockStyle.Bottom;
            pnlTimeInfo.FlowDirection = FlowDirection.RightToLeft;
            pnlTimeInfo.Location = new Point(0, 161);
            pnlTimeInfo.Name = "pnlTimeInfo";
            pnlTimeInfo.Size = new Size(226, 31);
            pnlTimeInfo.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(151, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(72, 24);
            label2.TabIndex = 3;
            label2.Text = "المدة : ";
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Tahoma", 10F);
            lblDuration.ForeColor = Color.Gray;
            lblDuration.Location = new Point(124, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(21, 24);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(63, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 2;
            label1.Text = "دقيقة";
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlContent);
            pnlBody.Controls.Add(pnlTimeInfo);
            pnlBody.Controls.Add(pnlChoiceButtons);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 38);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(226, 229);
            pnlBody.TabIndex = 10;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(27, 44, 66);
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(226, 161);
            pnlContent.TabIndex = 8;
            // 
            // pnlChoiceButtons
            // 
            pnlChoiceButtons.Controls.Add(btnViewDetails);
            pnlChoiceButtons.Controls.Add(btnEdit);
            pnlChoiceButtons.Controls.Add(btnDelete);
            pnlChoiceButtons.Dock = DockStyle.Bottom;
            pnlChoiceButtons.Location = new Point(0, 192);
            pnlChoiceButtons.Name = "pnlChoiceButtons";
            pnlChoiceButtons.Size = new Size(226, 37);
            pnlChoiceButtons.TabIndex = 6;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pnlBody);
            Controls.Add(pnlHead);
            Margin = new Padding(0, 1, 0, 1);
            Name = "Note";
            Size = new Size(226, 267);
            pnlHead.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlTimeInfo.ResumeLayout(false);
            pnlTimeInfo.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlChoiceButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHead;
        private Label lblTitle;
        private Button btnToggleNote;
        private FlowLayoutPanel pnlTimeInfo;
        private Label label2;
        private Label lblDuration;
        private Label label1;
        private Label lblDescription;
        private Button btnViewDetails;
        private Button btnEdit;
        private Button btnDelete;
        private Panel pnlBody;
        private Panel pnlContent;
        private Panel pnlChoiceButtons;
        private Panel pnlTitle;
    }
}
