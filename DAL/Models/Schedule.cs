namespace DAL.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int SubjectId { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan Time { get; set; }

        public Subject Subject { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}