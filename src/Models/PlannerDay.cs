using System.Text.Json.Serialization;

namespace Weekly_Planner.Models
{
    /// <summary>
    /// Represents a single day and the activities planned for it.
    /// </summary>
    public class PlannerDay
    {
        /// <summary>
        /// Gets or sets the day represented by this plan.
        /// </summary>
        /// <value>The day name.</value>
        [JsonInclude]
        public DayName DayName { get; private set; } 
        /// <summary>
        /// Gets or sets the activities planned for the day.
        /// </summary>
        /// <value>The collection of activity details.</value>
        public List<ActivityDetails> ActivitiesList { get; set; }

        /// <summary>
        /// Initializes a new empty instance of the <see cref="PlannerDay"/> class.
        /// </summary>
        public PlannerDay()
        {
            DayName = DayName.Sun;
            ActivitiesList = new();
        }

        /// <summary>
        /// Initializes a day plan with the specified day name.
        /// </summary>
        /// <param name="name">The day represented by this plan.</param>
        public PlannerDay(DayName name) {
            DayName = name;
            ActivitiesList = new();
        }

        /// <summary>
        /// Initializes a day plan with a day name and an existing set of activities.
        /// </summary>
        /// <param name="name">The day represented by this plan.</param>
        /// <param name="activityDetails">The activities to copy into this plan.</param>
        public PlannerDay(DayName name ,ActivityDetails[] activityDetails)
        {
            DayName = name;
            ActivitiesList = new(activityDetails);
        }

    }
}