namespace Weekly_Planner.Models
{
    public class PlannerDay
    {
        /// <summary>
        /// Get or Set the Day Lists' tasks
        /// </summary>            
        public DayName DayName { get; private set; } 
        public List<ActivityDetails> ActivitiesList { get; set; }

        public PlannerDay()
        {

        }

        public PlannerDay(DayName name) {
            DayName = name;
            ActivitiesList = new();
        }

        public PlannerDay(DayName name ,ActivityDetails[] activityDetails)
        {
            DayName = name;
            ActivitiesList = new(activityDetails);
        }

    }
}