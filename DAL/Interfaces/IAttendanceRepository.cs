using DAL.Models;

namespace DAL.Interfaces
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        Task<Attendance> GetAsync(int id);
    }
}
