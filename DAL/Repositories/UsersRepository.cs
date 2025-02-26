using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationContext _applicationContext;

        public UsersRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Add(Users entity)
        {
            _applicationContext.Users.Add(entity);
            _applicationContext.SaveChanges();
        }

        public void Delete(Users entity)
        {
            _applicationContext.Users.Remove(entity);
            _applicationContext.SaveChanges();
        }

        public Users Get(int id)
        {
            return _applicationContext.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Users> GetAll()
        {
            return _applicationContext.Users.AsNoTracking().ToList();
        }

        public void Update(Users entity)
        {
            _applicationContext.Users.Update(entity);
            _applicationContext.SaveChanges();
        }
    }
}