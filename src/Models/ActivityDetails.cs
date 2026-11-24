namespace Weekly_Planner.Models
{
    /// <summary>
    /// Contains the title, description, and duration of a planned activity.
    /// </summary>
    public class ActivityDetails
    {
        /// <summary>
        /// Gets or sets the activity title.
        /// </summary>
        /// <value>The title displayed for the activity.</value>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the activity description.
        /// </summary>
        /// <value>The detailed text describing the activity.</value>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the duration of the activity in minutes.
        /// </summary>
        /// <value>The duration in minutes.</value>
        public int Duration { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetails"/> class.
        /// </summary>
        /// <param name="title">The activity title.</param>
        /// <param name="description">The activity description.</param>
        /// <param name="duration">The activity duration in minutes.</param>
        public ActivityDetails(string title, string description, int duration)
        {
            Title = title;
            Description = description;
            Duration = duration;
        }

    }
}