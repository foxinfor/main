using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationContext _applicationContext;

        public SubjectRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task AddAsync(Subject entity)
        {
            await _applicationContext.Subject.AddAsync(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Subject entity)
        {
            _applicationContext.Subject.Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Subject>> GetAllAsync()
        {
            return await _applicationContext.Subject.AsNoTracking().ToListAsync();
        }

        public async Task<Subject> GetAsync(int id)
        {
            return await _applicationContext.Subject.FindAsync(id);
        }

        public async Task UpdateAsync(Subject entity)
        {
            _applicationContext.Subject.Update(entity);
            await _applicationContext.SaveChangesAsync();
        }
    }
}