namespace Weekly_Planner.Models
{
    public class ActivityInfo
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Get or set the duration of the activity in minutes.
        /// </summary>
        public int Duration { get; set; } = 0;

        public ActivityInfo(string title, string description, int duration)
        {
            Title = title;
            Description = description;
            Duration = duration;
        }

        public ActivityInfo()
        {
        }
    }
}