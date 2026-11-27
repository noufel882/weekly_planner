using Weekly_Planner.Controls;
using Weekly_Planner.Models;

namespace Weekly_Planner
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            lblPlannedDays = new Label();
            label4 = new Label();
            lblActivitiesCount = new Label();
            label3 = new Label();
            lblTotalTime = new Label();
            btnSave = new Button();
            btnImport = new Button();
            label12 = new Label();
            WeekTable = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            pnlThursday = new DayPanel();
            pnlFriday = new DayPanel();
            pnlSaturday = new DayPanel();
            pnlSunday = new DayPanel();
            pnlWednesday = new DayPanel();
            pnlTuesday = new DayPanel();
            pnlMonday = new DayPanel();
            label2 = new Label();
            panel1.SuspendLayout();
            WeekTable.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(1, 34, 38, 74);
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1358, 26);
            label1.Name = "label1";
            label1.Size = new Size(366, 58);
            label1.TabIndex = 0;
            label1.Text = "مخطط الأسبوع";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(27, 44, 66);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblPlannedDays);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblActivitiesCount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotalTime);
            panel1.Font = new Font("Tahoma", 12F);
            panel1.Location = new Point(16, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1730, 147);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(1, 34, 38, 74);
            label6.Font = new Font("Tahoma", 16F);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(148, 14);
            label6.Name = "label6";
            label6.Size = new Size(302, 39);
            label6.TabIndex = 6;
            label6.Text = "عدد الايام المخطط لها";
            // 
            // lblPlannedDays
            // 
            lblPlannedDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlannedDays.AutoSize = true;
            lblPlannedDays.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblPlannedDays.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            lblPlannedDays.ForeColor = SystemColors.ControlLight;
            lblPlannedDays.Location = new Point(316, 81);
            lblPlannedDays.Name = "lblPlannedDays";
            lblPlannedDays.Size = new Size(93, 48);
            lblPlannedDays.TabIndex = 5;
            lblPlannedDays.Text = "7/0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(1, 34, 38, 74);
            label4.Font = new Font("Tahoma", 16F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(803, 14);
            label4.Name = "label4";
            label4.Size = new Size(189, 39);
            label4.TabIndex = 4;
            label4.Text = "عدد الأنشطة";
            // 
            // lblActivitiesCount
            // 
            lblActivitiesCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblActivitiesCount.AutoSize = true;
            lblActivitiesCount.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblActivitiesCount.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            lblActivitiesCount.ForeColor = SystemColors.ControlLight;
            lblActivitiesCount.Location = new Point(931, 81);
            lblActivitiesCount.Name = "lblActivitiesCount";
            lblActivitiesCount.Size = new Size(45, 48);
            lblActivitiesCount.TabIndex = 3;
            lblActivitiesCount.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(1, 34, 38, 74);
            label3.Font = new Font("Tahoma", 16F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(1414, 14);
            label3.Name = "label3";
            label3.Size = new Size(285, 39);
            label3.TabIndex = 2;
            label3.Text = "مجموع وقت الأسبوع";
            // 
            // lblTotalTime
            // 
            lblTotalTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalTime.AutoSize = true;
            lblTotalTime.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblTotalTime.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            lblTotalTime.ForeColor = SystemColors.ControlLight;
            lblTotalTime.Location = new Point(1655, 81);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(45, 48);
            lblTotalTime.TabIndex = 1;
            lblTotalTime.Text = "0";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(79, 209, 197);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(13, 19, 31);
            btnSave.Location = new Point(41, 19);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 69);
            btnSave.TabIndex = 3;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(27, 44, 66);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Popup;
            btnImport.Font = new Font("Tahoma", 14F);
            btnImport.ForeColor = Color.FromArgb(79, 209, 197);
            btnImport.Location = new Point(332, 19);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(228, 69);
            btnImport.TabIndex = 4;
            btnImport.Text = "إستيراد";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 6F);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(20, 788);
            label12.Name = "label12";
            label12.Size = new Size(72, 14);
            label12.TabIndex = 5;
            label12.Text = "version : V1";
            // 
            // WeekTable
            // 
            WeekTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeekTable.BackColor = Color.FromArgb(20, 30, 48);
            WeekTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            WeekTable.ColumnCount = 7;
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            WeekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTable.Controls.Add(label11, 6, 0);
            WeekTable.Controls.Add(label10, 5, 0);
            WeekTable.Controls.Add(label9, 4, 0);
            WeekTable.Controls.Add(label8, 3, 0);
            WeekTable.Controls.Add(label7, 2, 0);
            WeekTable.Controls.Add(label5, 1, 0);
            WeekTable.Controls.Add(pnlThursday, 0, 1);
            WeekTable.Controls.Add(pnlFriday, 6, 1);
            WeekTable.Controls.Add(pnlSaturday, 5, 1);
            WeekTable.Controls.Add(pnlSunday, 4, 1);
            WeekTable.Controls.Add(pnlWednesday, 1, 1);
            WeekTable.Controls.Add(pnlTuesday, 2, 1);
            WeekTable.Controls.Add(pnlMonday, 3, 1);
            WeekTable.Controls.Add(label2, 0, 0);
            WeekTable.Font = new Font("Tahoma", 12F);
            WeekTable.Location = new Point(16, 291);
            WeekTable.Name = "WeekTable";
            WeekTable.RowCount = 2;
            WeekTable.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            WeekTable.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            WeekTable.Size = new Size(1730, 479);
            WeekTable.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(1485, 1);
            label11.Name = "label11";
            label11.Size = new Size(241, 95);
            label11.TabIndex = 10;
            label11.Text = "الجمعة";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(1239, 1);
            label10.Name = "label10";
            label10.Size = new Size(239, 95);
            label10.TabIndex = 9;
            label10.Text = "السبت";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(992, 1);
            label9.Name = "label9";
            label9.Size = new Size(240, 95);
            label9.TabIndex = 8;
            label9.Text = "الأحد";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(745, 1);
            label8.Name = "label8";
            label8.Size = new Size(240, 95);
            label8.TabIndex = 7;
            label8.Text = "الإثنين";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(498, 1);
            label7.Name = "label7";
            label7.Size = new Size(240, 95);
            label7.TabIndex = 6;
            label7.Text = "الثلاثاء";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(251, 1);
            label5.Name = "label5";
            label5.Size = new Size(240, 95);
            label5.TabIndex = 5;
            label5.Text = "الأربعاء";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlThursday
            // 
            pnlThursday.AutoScroll = true;
            pnlThursday.DayName = DayName.Thu;
            pnlThursday.Dock = DockStyle.Fill;
            pnlThursday.FlowDirection = FlowDirection.TopDown;
            pnlThursday.Font = new Font("Tahoma", 12F);
            pnlThursday.Location = new Point(4, 100);
            pnlThursday.Name = "pnlThursday";
            pnlThursday.Padding = new Padding(0, 3, 0, 3);
            pnlThursday.Size = new Size(240, 375);
            pnlThursday.TabIndex = 0;
            pnlThursday.WrapContents = false;
            pnlThursday.ActivityChanged += UpdateStatus;
            // 
            // pnlFriday
            // 
            pnlFriday.AutoScroll = true;
            pnlFriday.DayName = DayName.Fri;
            pnlFriday.Dock = DockStyle.Fill;
            pnlFriday.FlowDirection = FlowDirection.TopDown;
            pnlFriday.Font = new Font("Tahoma", 12F);
            pnlFriday.Location = new Point(1485, 100);
            pnlFriday.Name = "pnlFriday";
            pnlFriday.Padding = new Padding(0, 3, 0, 3);
            pnlFriday.Size = new Size(241, 375);
            pnlFriday.TabIndex = 1;
            pnlFriday.WrapContents = false;
            pnlFriday.ActivityChanged += UpdateStatus;
            // 
            // pnlSaturday
            // 
            pnlSaturday.AutoScroll = true;
            pnlSaturday.DayName = DayName.Sat;
            pnlSaturday.Dock = DockStyle.Fill;
            pnlSaturday.FlowDirection = FlowDirection.TopDown;
            pnlSaturday.Font = new Font("Tahoma", 12F);
            pnlSaturday.Location = new Point(1239, 100);
            pnlSaturday.Name = "pnlSaturday";
            pnlSaturday.Padding = new Padding(0, 3, 0, 3);
            pnlSaturday.Size = new Size(239, 375);
            pnlSaturday.TabIndex = 1;
            pnlSaturday.WrapContents = false;
            pnlSaturday.ActivityChanged += UpdateStatus;
            // 
            // pnlSunday
            // 
            pnlSunday.AutoScroll = true;
            pnlSunday.DayName = DayName.Sun;
            pnlSunday.Dock = DockStyle.Fill;
            pnlSunday.FlowDirection = FlowDirection.TopDown;
            pnlSunday.Font = new Font("Tahoma", 12F);
            pnlSunday.Location = new Point(992, 100);
            pnlSunday.Name = "pnlSunday";
            pnlSunday.Padding = new Padding(0, 3, 0, 3);
            pnlSunday.Size = new Size(240, 375);
            pnlSunday.TabIndex = 1;
            pnlSunday.WrapContents = false;
            pnlSunday.ActivityChanged += UpdateStatus;
            // 
            // pnlWednesday
            // 
            pnlWednesday.AutoScroll = true;
            pnlWednesday.DayName = DayName.Wed;
            pnlWednesday.Dock = DockStyle.Fill;
            pnlWednesday.FlowDirection = FlowDirection.TopDown;
            pnlWednesday.Font = new Font("Tahoma", 12F);
            pnlWednesday.Location = new Point(251, 100);
            pnlWednesday.Name = "pnlWednesday";
            pnlWednesday.Padding = new Padding(0, 3, 0, 3);
            pnlWednesday.Size = new Size(240, 375);
            pnlWednesday.TabIndex = 1;
            pnlWednesday.WrapContents = false;
            pnlWednesday.ActivityChanged += UpdateStatus;
            // 
            // pnlTuesday
            // 
            pnlTuesday.AutoScroll = true;
            pnlTuesday.DayName = DayName.Tue;
            pnlTuesday.Dock = DockStyle.Fill;
            pnlTuesday.FlowDirection = FlowDirection.TopDown;
            pnlTuesday.Font = new Font("Tahoma", 12F);
            pnlTuesday.Location = new Point(498, 100);
            pnlTuesday.Name = "pnlTuesday";
            pnlTuesday.Padding = new Padding(0, 3, 0, 3);
            pnlTuesday.Size = new Size(240, 375);
            pnlTuesday.TabIndex = 2;
            pnlTuesday.WrapContents = false;
            pnlTuesday.ActivityChanged += UpdateStatus;
            // 
            // pnlMonday
            // 
            pnlMonday.AutoScroll = true;
            pnlMonday.DayName = DayName.Mon;
            pnlMonday.Dock = DockStyle.Fill;
            pnlMonday.FlowDirection = FlowDirection.TopDown;
            pnlMonday.Font = new Font("Tahoma", 12F);
            pnlMonday.Location = new Point(745, 100);
            pnlMonday.Name = "pnlMonday";
            pnlMonday.Padding = new Padding(0, 3, 0, 3);
            pnlMonday.Size = new Size(240, 375);
            pnlMonday.TabIndex = 3;
            pnlMonday.WrapContents = false;
            pnlMonday.ActivityChanged += UpdateStatus;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(4, 1);
            label2.Name = "label2";
            label2.Size = new Size(240, 95);
            label2.TabIndex = 4;
            label2.Text = "الخميس";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(1760, 815);
            Controls.Add(WeekTable);
            Controls.Add(label12);
            Controls.Add(btnImport);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "main";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            WeekTable.ResumeLayout(false);
            WeekTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label lblPlannedDays;
        private Label label4;
        private Label lblActivitiesCount;
        private Label label3;
        private Label lblTotalTime;

        private Button btnSave;
        private Button btnImport;

        private Label label12;
        private DayPanel pnlWednesday;
        private DayPanel pnlTuesday;
        private DayPanel pnlMonday;
        private TableLayoutPanel WeekTable;
        private DayPanel pnlThursday;
        private DayPanel pnlFriday;
        private DayPanel pnlSaturday;
        private DayPanel pnlSunday;

        private Label label2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
    }
}
