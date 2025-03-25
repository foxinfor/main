using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationContext _applicationContext;

        public GroupRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task AddAsync(Group entity)
        {
            await _applicationContext.Group.AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Group entity)
        {
            _applicationContext.Group.Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<Group> GetAsync(int id)
        {
            return await _applicationContext.Group.FindAsync(id);
        }

        public async Task<IEnumerable<Group>> GetAllAsync()
        {
            return await _applicationContext.Group.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(Group entity)
        {
            _applicationContext.Group.Update(entity);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
