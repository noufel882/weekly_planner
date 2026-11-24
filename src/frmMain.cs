#pragma warning disable WFO1000 // disabled warnings for this file

using Weekly_Planner.Controls;
using Weekly_Planner.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Weekly_Planner
{
    /// <summary>
    /// Represents the main weekly planner window and coordinates its day panels and summary values.
    /// </summary>
    public partial class frmMain : Form
    {
        private int _taskCount = 0;
        private int _totalPlannedTime = 0;
        private int _plannedDays = 0;

        /// <summary>
        /// Gets or sets the total number of activities across all planned days.
        /// </summary>
        /// <value>The number of activities.</value>
        public int TasksCount
        {
            get => _taskCount;
            set
            {
                _taskCount = value;
                lblActivitiesCount.Text = _taskCount.ToString();
            }
        }
        /// <summary>
        /// Gets or sets the number of days that contain at least one activity.
        /// </summary>
        /// <value>The number of planned days, displayed as part of a seven-day week.</value>
        public int PlanningDays
        {
            get => _plannedDays;
            set
            {
                _plannedDays = value;
                lblPlannedDays.Text = "7/" + _plannedDays;
            }
        }

        /// <summary>
        /// Gets or sets the total planned time in minutes.
        /// </summary>
        /// <value>The total planned duration formatted and displayed by the main form.</value>
        public int TotalPlannedTime
        {
            get => _totalPlannedTime;
            set
            {
                _totalPlannedTime = value;
                var time = TimeSpan.FromMinutes(_totalPlannedTime);
                lblTotalTime.Text = $" يوم {time.Days} " + $" ساعة {time.Hours} " + $" دقيقة {time.Minutes} ";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            TasksCount = 0;
            TotalPlannedTime = 0;
            PlanningDays = 0;
        }


        /// <summary>
        /// Recalculates the summary displayed in the main window.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void UpdateStatus(object sender, EventArgs e)
        {
            int plannedDays = 0;
            int totalPlannedTime = 0;
            int taskCount = 0;

            foreach (var item in tlpDaysTable.Controls)
            {
                if (item is DaysPanel dayPanel)
                {
                    if (dayPanel.TasksCount > 0)
                    {
                        plannedDays++;
                        taskCount += dayPanel.TasksCount;
                        totalPlannedTime += dayPanel.TotalPlannedTime;
                    }
                }
            }

            // Update the UI labels with the new values
            PlanningDays = plannedDays;
            TotalPlannedTime = totalPlannedTime;
            TasksCount = taskCount;

        }

        /// <summary>
        /// Prompts the user to choose a JSON file and exports all day plans.
        /// </summary>
        /// <param name="sender">The export button that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new();
            dialog.Title = "Export Weekly Planner";
            dialog.FileName = "WeeklyPlanner.json";
            dialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            dialog.DefaultExt = "json";
            dialog.AddExtension = true;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.OverwritePrompt = true;
            dialog.CheckPathExists = true;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var filepath = dialog.FileName;
            PlannerDay[] days =
            {
                pnlSunday.ToPlannerDay(),
                pnlMonday.ToPlannerDay(),
                pnlTuesday.ToPlannerDay(),
                pnlWednesday.ToPlannerDay(),
                pnlThursday.ToPlannerDay(),
                pnlFriday.ToPlannerDay(),
                pnlSaturday.ToPlannerDay(),

            };

            ActivityStorage.Export(filepath, days);
        }

        /// <summary>
        /// Prompts the user to choose a JSON file and imports all day plans.
        /// </summary>
        /// <param name="sender">The import button that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Title = "Import Weekly Planner";
            dialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            dialog.DefaultExt = "json";
            dialog.AddExtension = true;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.CheckPathExists = true;

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var filepath = dialog.FileName;
            PlannerDay[] days = ActivityStorage.Import(filepath)!;


            this.SuspendLayout();

            foreach (var day in days)
            {
               
                switch (day.DayName)
                {
                    case DayName.Sun:
                        pnlSunday.Load(day);
                        break;

                    case DayName.Mon:
                        pnlMonday.Load(day);
                        break;

                    case DayName.Tue:
                        pnlTuesday.Load(day);
                        break;

                    case DayName.Wed:
                        pnlWednesday.Load(day);
                        break;

                    case DayName.Thu:
                        pnlThursday.Load(day);
                        break;

                    case DayName.Fri:
                        pnlFriday.Load(day);
                        break;

                    case DayName.Sat:
                        pnlSaturday.Load(day);
                        break;
                }
            }

            this.ResumeLayout(false);
            this.PerformLayout();
        }

       
    }
}