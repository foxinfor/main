using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private ApplicationContext applicationContext;

        public UsersRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            return applicationContext.Users.AsNoTracking().ToList();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
