namespace Weekly_Planner.Models
{
    public enum DayName {Sun,Mon,Tue,Wed,Thu,Fri,Sat}

    public class PlannerDay
    {
        /// <summary>
        /// Get or Set the Day Lists' tasks
        /// </summary>            
        public DayName Name { get; private set; } 
        public List<ActivityDetails> ActivitiesList { get; set; }
        public PlannerDay(DayName name) {
            Name = name;
            ActivitiesList = new();
        }

        public PlannerDay(DayName name ,ActivityDetails[] activityDetails)
        {
            Name = name;
            ActivitiesList = new(activityDetails);
        }

    }
}