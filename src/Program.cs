

namespace Weekly_Planner
{
    /// <summary>
    /// Provides the application entry point and initializes the Windows Forms runtime.
    /// </summary>
    internal static class Program
    {
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string planPath = Properties.Settings.Default.PlanPath;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            frmMain mainForm;

            if (!string.IsNullOrWhiteSpace(planPath))
                mainForm = new frmMain(planPath);
            else
                mainForm = new frmMain();

            Application.Run(mainForm);

        }
    }
}