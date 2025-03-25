using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationContext _applicationContext;

        public AttendanceRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task AddAsync(Attendance entity)
        {
            await _applicationContext.Attendance.AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Attendance entity)
        {
            _applicationContext.Attendance.Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<Attendance> GetAsync(int id)
        {
            return await _applicationContext.Attendance.FindAsync(id);
        }

        public async Task<IEnumerable<Attendance>> GetAllAsync()
        {
            return await _applicationContext.Attendance
                .Include(a => a.User) 
                .Include(a => a.Schedule) 
                .ToListAsync();
        }

        public async Task UpdateAsync(Attendance entity)
        {
            _applicationContext.Attendance.Update(entity);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
