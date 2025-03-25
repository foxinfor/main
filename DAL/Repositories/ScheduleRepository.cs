using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ScheduleRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task AddAsync(Schedule entity)
        {
            await _applicationContext.Schedule.AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Schedule entity)
        {
            _applicationContext.Schedule.Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await _applicationContext.Schedule.AsNoTracking().ToListAsync();
        }

        public async Task<Schedule> GetAsync(int id)
        {
            return await _applicationContext.Schedule.FindAsync(id);
        }

        public async Task UpdateAsync(Schedule entity)
        {
            _applicationContext.Schedule.Update(entity);
            await _applicationContext.SaveChangesAsync();
        }
    }
}