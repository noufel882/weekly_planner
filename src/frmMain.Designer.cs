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
            tlpDaysTable = new TableLayoutPanel();
            pnlSunday = new Weekly_Planner.Controls.DaysPanel();
            pnlMonday = new Weekly_Planner.Controls.DaysPanel();
            pnlTuesday = new Weekly_Planner.Controls.DaysPanel();
            pnlWednesday = new Weekly_Planner.Controls.DaysPanel();
            pnlThursday = new Weekly_Planner.Controls.DaysPanel();
            pnlFriday = new Weekly_Planner.Controls.DaysPanel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            pnlSaturday = new Weekly_Planner.Controls.DaysPanel();
            panel1.SuspendLayout();
            tlpDaysTable.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(1, 34, 38, 74);
            label1.Font = new Font("Tahoma", 21F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(1426, 38);
            label1.Name = "label1";
            label1.Size = new Size(320, 51);
            label1.TabIndex = 0;
            label1.Text = "مخطط الأسبوع";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(34, 28, 52);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblPlannedDays);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblActivitiesCount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotalTime);
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
            label6.Font = new Font("Tahoma", 13F);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(181, 30);
            label6.Name = "label6";
            label6.Size = new Size(243, 31);
            label6.TabIndex = 6;
            label6.Text = "عدد الايام المخطط لها";
            // 
            // lblPlannedDays
            // 
            lblPlannedDays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlannedDays.AutoSize = true;
            lblPlannedDays.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblPlannedDays.Font = new Font("Tahoma", 21F, FontStyle.Bold);
            lblPlannedDays.ForeColor = SystemColors.ControlLight;
            lblPlannedDays.Location = new Point(316, 81);
            lblPlannedDays.Name = "lblPlannedDays";
            lblPlannedDays.Size = new Size(100, 51);
            lblPlannedDays.TabIndex = 5;
            lblPlannedDays.Text = "7/0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(1, 34, 38, 74);
            label4.Font = new Font("Tahoma", 13F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(826, 30);
            label4.Name = "label4";
            label4.Size = new Size(153, 31);
            label4.TabIndex = 4;
            label4.Text = "عدد الأنشطة";
            // 
            // lblActivitiesCount
            // 
            lblActivitiesCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblActivitiesCount.AutoSize = true;
            lblActivitiesCount.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblActivitiesCount.Font = new Font("Tahoma", 21F, FontStyle.Bold);
            lblActivitiesCount.ForeColor = SystemColors.ControlLight;
            lblActivitiesCount.Location = new Point(931, 81);
            lblActivitiesCount.Name = "lblActivitiesCount";
            lblActivitiesCount.Size = new Size(49, 51);
            lblActivitiesCount.TabIndex = 3;
            lblActivitiesCount.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(1, 34, 38, 74);
            label3.Font = new Font("Tahoma", 13F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(1472, 30);
            label3.Name = "label3";
            label3.Size = new Size(235, 31);
            label3.TabIndex = 2;
            label3.Text = "مجموع وقت الأسبوع";
            // 
            // lblTotalTime
            // 
            lblTotalTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalTime.AutoSize = true;
            lblTotalTime.BackColor = Color.FromArgb(1, 34, 38, 74);
            lblTotalTime.Font = new Font("Tahoma", 21F, FontStyle.Bold);
            lblTotalTime.ForeColor = SystemColors.ControlLight;
            lblTotalTime.Location = new Point(1655, 81);
            lblTotalTime.Name = "lblTotalTime";
            lblTotalTime.Size = new Size(49, 51);
            lblTotalTime.TabIndex = 1;
            lblTotalTime.Text = "0";
            // 
            // tlpDaysTable
            // 
            tlpDaysTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDaysTable.BackColor = Color.FromArgb(34, 28, 52);
            tlpDaysTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpDaysTable.ColumnCount = 7;
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tlpDaysTable.Controls.Add(pnlSunday, 6, 1);
            tlpDaysTable.Controls.Add(pnlMonday, 5, 1);
            tlpDaysTable.Controls.Add(pnlTuesday, 4, 1);
            tlpDaysTable.Controls.Add(pnlWednesday, 3, 1);
            tlpDaysTable.Controls.Add(pnlThursday, 2, 1);
            tlpDaysTable.Controls.Add(pnlFriday, 1, 1);
            tlpDaysTable.Controls.Add(label11, 5, 0);
            tlpDaysTable.Controls.Add(label10, 4, 0);
            tlpDaysTable.Controls.Add(label9, 3, 0);
            tlpDaysTable.Controls.Add(label8, 2, 0);
            tlpDaysTable.Controls.Add(label7, 1, 0);
            tlpDaysTable.Controls.Add(label2, 6, 0);
            tlpDaysTable.Controls.Add(label5, 0, 0);
            tlpDaysTable.Controls.Add(pnlSaturday, 0, 1);
            tlpDaysTable.Location = new Point(16, 286);
            tlpDaysTable.Name = "tlpDaysTable";
            tlpDaysTable.RowCount = 2;
            tlpDaysTable.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpDaysTable.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tlpDaysTable.Size = new Size(1730, 511);
            tlpDaysTable.TabIndex = 2;
            // 
            // pnlSunday
            // 
            pnlSunday.AutoScroll = true;
            pnlSunday.Dock = DockStyle.Fill;
            pnlSunday.FlowDirection = FlowDirection.TopDown;
            pnlSunday.Location = new Point(1485, 81);
            pnlSunday.Name = "pnlSunday";
            pnlSunday.Padding = new Padding(0, 3, 0, 3);
            pnlSunday.Size = new Size(241, 426);
            pnlSunday.TabIndex = 20;
            pnlSunday.TasksCount = 0;
            pnlSunday.WrapContents = false;
            pnlSunday.ActivityAdded += daysPanel_TaskAdded;
            pnlSunday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // pnlMonday
            // 
            pnlMonday.AutoScroll = true;
            pnlMonday.Dock = DockStyle.Fill;
            pnlMonday.FlowDirection = FlowDirection.TopDown;
            pnlMonday.Location = new Point(1238, 81);
            pnlMonday.Name = "pnlMonday";
            pnlMonday.Padding = new Padding(0, 3, 0, 3);
            pnlMonday.Size = new Size(240, 426);
            pnlMonday.TabIndex = 19;
            pnlMonday.TasksCount = 0;
            pnlMonday.WrapContents = false;
            pnlMonday.ActivityAdded += daysPanel_TaskAdded;
            pnlMonday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // pnlTuesday
            // 
            pnlTuesday.AutoScroll = true;
            pnlTuesday.Dock = DockStyle.Fill;
            pnlTuesday.FlowDirection = FlowDirection.TopDown;
            pnlTuesday.Location = new Point(991, 81);
            pnlTuesday.Name = "pnlTuesday";
            pnlTuesday.Padding = new Padding(0, 3, 0, 3);
            pnlTuesday.Size = new Size(240, 426);
            pnlTuesday.TabIndex = 18;
            pnlTuesday.TasksCount = 0;
            pnlTuesday.WrapContents = false;
            pnlTuesday.ActivityAdded += daysPanel_TaskAdded;
            pnlTuesday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // pnlWednsday
            // 
            pnlWednesday.AutoScroll = true;
            pnlWednesday.Dock = DockStyle.Fill;
            pnlWednesday.FlowDirection = FlowDirection.TopDown;
            pnlWednesday.Location = new Point(744, 81);
            pnlWednesday.Name = "pnlWednsday";
            pnlWednesday.Padding = new Padding(0, 3, 0, 3);
            pnlWednesday.Size = new Size(240, 426);
            pnlWednesday.TabIndex = 17;
            pnlWednesday.TasksCount = 0;
            pnlWednesday.WrapContents = false;
            pnlWednesday.ActivityAdded += daysPanel_TaskAdded;
            pnlWednesday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // pnlThusday
            // 
            pnlThursday.AutoScroll = true;
            pnlThursday.Dock = DockStyle.Fill;
            pnlThursday.FlowDirection = FlowDirection.TopDown;
            pnlThursday.Location = new Point(497, 81);
            pnlThursday.Name = "pnlThusday";
            pnlThursday.Padding = new Padding(0, 3, 0, 3);
            pnlThursday.Size = new Size(240, 426);
            pnlThursday.TabIndex = 16;
            pnlThursday.TasksCount = 0;
            pnlThursday.WrapContents = false;
            pnlThursday.ActivityAdded += daysPanel_TaskAdded;
            pnlThursday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // pnlFriday
            // 
            pnlFriday.AutoScroll = true;
            pnlFriday.Dock = DockStyle.Fill;
            pnlFriday.FlowDirection = FlowDirection.TopDown;
            pnlFriday.Location = new Point(250, 81);
            pnlFriday.Name = "pnlFriday";
            pnlFriday.Padding = new Padding(0, 3, 0, 3);
            pnlFriday.Size = new Size(240, 426);
            pnlFriday.TabIndex = 15;
            pnlFriday.TasksCount = 0;
            pnlFriday.WrapContents = false;
            pnlFriday.ActivityAdded += daysPanel_TaskAdded;
            pnlFriday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(1, 34, 38, 74);
            label11.Font = new Font("Tahoma", 18F);
            label11.ForeColor = SystemColors.ControlLight;
            label11.Location = new Point(1238, 1);
            label11.Name = "label11";
            label11.Size = new Size(240, 76);
            label11.TabIndex = 13;
            label11.Text = "الإثنين";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(1, 34, 38, 74);
            label10.Font = new Font("Tahoma", 18F);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(991, 1);
            label10.Name = "label10";
            label10.Size = new Size(240, 76);
            label10.TabIndex = 12;
            label10.Text = "الثلاثاء";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(1, 34, 38, 74);
            label9.Font = new Font("Tahoma", 18F);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(744, 1);
            label9.Name = "label9";
            label9.Size = new Size(240, 76);
            label9.TabIndex = 11;
            label9.Text = "الأربعاء";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(1, 34, 38, 74);
            label8.Font = new Font("Tahoma", 18F);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(497, 1);
            label8.Name = "label8";
            label8.Size = new Size(240, 76);
            label8.TabIndex = 10;
            label8.Text = "الخميس";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(1, 34, 38, 74);
            label7.Font = new Font("Tahoma", 18F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(250, 1);
            label7.Name = "label7";
            label7.Size = new Size(240, 76);
            label7.TabIndex = 9;
            label7.Text = "الجمعة";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(1, 34, 38, 74);
            label2.Font = new Font("Tahoma", 18F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(1485, 1);
            label2.Name = "label2";
            label2.Size = new Size(241, 76);
            label2.TabIndex = 7;
            label2.Text = "الأحد";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(1, 34, 38, 74);
            label5.Font = new Font("Tahoma", 18F);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(4, 1);
            label5.Name = "label5";
            label5.Size = new Size(239, 76);
            label5.TabIndex = 8;
            label5.Text = "السبت";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSaturday
            // 
            pnlSaturday.AutoScroll = true;
            pnlSaturday.Dock = DockStyle.Fill;
            pnlSaturday.FlowDirection = FlowDirection.TopDown;
            pnlSaturday.Location = new Point(4, 81);
            pnlSaturday.Name = "pnlSaturday";
            pnlSaturday.Padding = new Padding(0, 3, 0, 3);
            pnlSaturday.Size = new Size(239, 426);
            pnlSaturday.TabIndex = 14;
            pnlSaturday.TasksCount = 0;
            pnlSaturday.WrapContents = false;
            pnlSaturday.ActivityAdded += daysPanel_TaskAdded;
            pnlSaturday.ActivityRemoved += daysPanel_TaskRemoved;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(23, 28, 52);
            ClientSize = new Size(1760, 815);
            Controls.Add(tlpDaysTable);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "main";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tlpDaysTable.ResumeLayout(false);
            tlpDaysTable.PerformLayout();
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
        private TableLayoutPanel tlpDaysTable;
        private Label label2;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Controls.DaysPanel pnlSunday;
        private Controls.DaysPanel pnlMonday;
        private Controls.DaysPanel pnlTuesday;
        private Controls.DaysPanel pnlWednesday;
        private Controls.DaysPanel pnlThursday;
        private Controls.DaysPanel pnlFriday;
        private Controls.DaysPanel pnlSaturday;
    }
}
