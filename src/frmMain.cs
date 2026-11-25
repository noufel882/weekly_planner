#pragma warning disable WFO1000 // disabled warnings for this file

using System.Windows.Forms.VisualStyles;
using Weekly_Planner.Controls;
using Weekly_Planner.Models;

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

        private string _currentPath = string.Empty;

        private bool _planSaved = true;


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
        private void UpdateStatus(object sender, ActivityChangeTypeEventArgs e)
        {
            var dayPanel = (DayPanel)sender!;

            if (e.ChangeType == ActivityChangeType.ADDING)
            {
                foreach (var activity in e.New!)
                {
                    TotalPlannedTime += activity.Duration;
                    TasksCount++;
                }
                PlanningDays++;
            }

            else if (e.ChangeType == ActivityChangeType.REMOVING)
            {
                foreach (var activity in e.Old!)
                {
                    TotalPlannedTime -= activity.Duration;
                    TasksCount--;
                }
                if (dayPanel.TasksCount == 0)
                    PlanningDays--;
            }

            else
            {
                for (int i = 0; i < e.New!.Length; i++)
                {
                    TotalPlannedTime += e.New[i].Duration - e.Old![i].Duration;
                }
            }

            MarkedAsUnsaved();
        }
     

        /// <summary>
        /// Prompts the user to choose a JSON file and exports all day plans.
        /// </summary>
        /// <param name="sender">The export button that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var savePath = string.Empty;
            if (string.IsNullOrWhiteSpace(_currentPath))
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
                savePath = dialog.FileName;
            }
            else
                savePath = _currentPath;

            SavePlan(savePath);
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


            var loadPath = dialog.FileName;

            LoadPlan(loadPath);
        }

        private void LoadPlan(string loadPath)
        {
            PlannerDay[]? days = StorageManager.Import(loadPath);

            if (days is null)
            {
                MessageBox.Show("الملف اللذي اخترته تالف أو غير صالح للستعمال ، الرجاء إختيار ملف اخر"
                    , "فشل التحميل",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                return;
            }


            this.SuspendLayout();

            foreach (var day in days)
            {

                switch (day.DayName)
                {
                    case DayName.Sun:
                        pnlSunday.Add(day);
                        break;

                    case DayName.Mon:
                        pnlMonday.Add(day);
                        break;

                    case DayName.Tue:
                        pnlTuesday.Add(day);
                        break;

                    case DayName.Wed:
                        pnlWednesday.Add(day);
                        break;

                    case DayName.Thu:
                        pnlThursday.Add(day);
                        break;

                    case DayName.Fri:
                        pnlFriday.Add(day);
                        break;

                    case DayName.Sat:
                        pnlSaturday.Add(day);
                        break;
                }
            }


            this.ResumeLayout(false);
            this.PerformLayout();

            MarkedAsSavedInPath(loadPath);
        }

        private void SavePlan(string savePath)
        {
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

            _planSaved = StorageManager.Export(savePath, days);

            if (_planSaved)
            {
                MessageBox.Show("تم الحفظ بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MarkedAsSavedInPath(savePath);
            }
            else
            {
                MessageBox.Show("فشلت عملية حفظ الجدول", "فشل الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MarkedAsUnsaved();
            }

        }

        private void MarkedAsUnsaved()
        {
            _planSaved = false;
            this.Text = _currentPath + (_planSaved ? "" : " * ");
        }

        private void MarkedAsSavedInPath(string path)
        {
            _planSaved = true;
            _currentPath = path;
            this.Text = _currentPath + (_planSaved ? "" : " * ");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_planSaved && MessageBox.Show("انت لم تقم بحفظ التعديلات ، هل تريد الحفظ ؟","حفظ التعديلات",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnSave.PerformClick();
                e.Cancel = true;
                return;
            }
        }
    
    
    }
}