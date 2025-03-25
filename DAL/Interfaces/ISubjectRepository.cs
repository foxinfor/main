using DAL.Models;

namespace DAL.Interfaces
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        Task<Subject> GetAsync(int id);
    }
}
