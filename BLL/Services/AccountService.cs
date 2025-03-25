using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUsersRepository usersRepository;
        private readonly IMapper mapper;
        private readonly JwtSettings _jwtSettings;


        public AccountService(IUsersRepository usersRepository, IMapper mapper,IOptions<JwtSettings> options)
        {
            this.usersRepository = usersRepository;
            this.mapper = mapper;
            _jwtSettings = options.Value;
        }


        ////
        //////
        public async Task<TokenDTO> LoginAsync(LoginDTO model)
        {
            var User =  await usersRepository.LoginAsync(model.Email, model.Password)??throw new ArgumentNullException("Такого нет");
            var JWTtoken = await GenerateJwtToken(User);


            return new TokenDTO
            {
                Token = "Bearer " + JWTtoken,
            };
        }

        private async Task<string> GenerateJwtToken(Users user)
        {
            var roles = await usersRepository.GetRolesAsync(user);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Issuer);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.UserName!),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, string.Join(",", roles))
            }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.Expire),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        /// /
        /// /
        /// /

        public async Task LogoutAsync()
        {
            await usersRepository.LogoutAsync();
        }

        public async Task RegisterAsync(RegisterDTO model)
        {
            await usersRepository.AddAsync(mapper.Map<Users>(model));
        }
    }
}
