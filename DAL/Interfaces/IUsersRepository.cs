using DAL.Models;

namespace DAL.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        Task<Users> LoginAsync(string email, string password);
        Task LogoutAsync();
        Task<List<string>> GetRolesAsync(Users user);

        Task<Users> GetAsync(string id);

    }
}
