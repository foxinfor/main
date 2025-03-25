using DAL.Models;

namespace DAL.Interfaces
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Task<Schedule> GetAsync(int id);
    }
}
