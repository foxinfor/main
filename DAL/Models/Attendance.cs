namespace DAL.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public string UserId { get; set; }
        public int ScheduleId { get; set; }
        public int GradeValue { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }
        public Users User { get; set; }
        public Schedule Schedule { get; set; }
    }
}