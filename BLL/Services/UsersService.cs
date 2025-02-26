using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    internal class UsersService : IUserService
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;

        public UsersService(IUsersRepository usersRepository, IMapper mapper)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
        }
        public void Add(UsersDTO item)
        {
            Users user = mapper.Map<Users>(item);
            usersRepository.Add(user);
        }
        public void Delete(UsersDTO item)
        {
            Users user = mapper.Map<Users>(item);
            usersRepository.Delete(user);
        }
        public void DeleteById(int id)
        {
            Users user = usersRepository.Get(id);
            if (user != null)
            {
                usersRepository.Delete(user);
            }
        }
        public UsersDTO FindById(int id)
        {
            Users user = usersRepository.Get(id);
            return mapper.Map<UsersDTO>(user);
        }
        public List<UsersDTO> GetAll()
        {
            var users = usersRepository.GetAll();
            return mapper.Map<List<UsersDTO>>(users);
        }
        public void Update(UsersDTO item)
        {
            Users user = mapper.Map<Users>(item);
            usersRepository.Update(user);
        }
    }
}