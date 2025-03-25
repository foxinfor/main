using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly UserManager<Users> userManager;
        private readonly SignInManager<Users> signInManager;

        public UsersRepository(ApplicationContext applicationContext, UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            _applicationContext = applicationContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task AddAsync(Users entity)
        {
            entity.UserName = entity.Email;

            await userManager.CreateAsync(entity,entity.PasswordHash!);
            await userManager.AddToRoleAsync(entity, "учащийся");
        }

        public async Task<Users> LoginAsync(string email, string password)
        {
            var User = await userManager.FindByEmailAsync(email);
            var result =  await signInManager.CheckPasswordSignInAsync(User, password, false);
            if(!result.Succeeded)
            {
                throw new Exception("Пользователя с таким login-ом и паролем не существует");
            }
            return User;
        }

        public async Task DeleteAsync(Users entity)
        {
            _applicationContext.Users.Remove(entity);
            await _applicationContext.SaveChangesAsync();
        }

        public async Task<Users> GetAsync(string id)
        {
            return await _applicationContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            return await _applicationContext.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public Task UpdateAsync(Users entity)
        {
            _applicationContext.Users.Update(entity);
            return _applicationContext.SaveChangesAsync();
        }

        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }


        public async Task<List<string>> GetRolesAsync(Users user)
        {
            return (List<string>)await userManager.GetRolesAsync(user);
        }
    }
}