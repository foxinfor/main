using DAL.Models;

namespace DAL.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        Task<Group> GetAsync(int id);
    }
}
