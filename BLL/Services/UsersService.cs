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
        public void Add(RegisterDTO item)
        {
            Users user = mapper.Map<Users>(item);
            usersRepository.AddAsync(user);
        }
        public void Delete(RegisterDTO item)
        {
            Users user = mapper.Map<Users>(item);
            usersRepository.DeleteAsync(user);
        }
        public async void DeleteById(string id)
        {
            Users user = await usersRepository.GetAsync(id);
            if (user != null)
            {
                await usersRepository.DeleteAsync(user);
            }
        }
        public async Task<RegisterDTO> FindByIdAsync(string id)
        {
            Users user = await usersRepository.GetAsync(id);
            return mapper.Map<RegisterDTO>(user);
        }

        public List<RegisterDTO> GetAll()
        {
            var users = usersRepository.GetAllAsync();
            return mapper.Map<List<RegisterDTO>>(users);
        }
        public void Update(RegisterDTO item)
        {
            Users user = mapper.Map<Users>(item);   
            usersRepository.UpdateAsync(user);
        }
    }
}