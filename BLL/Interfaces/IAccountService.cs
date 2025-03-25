using BLL.DTO;
using Microsoft.AspNetCore.Identity;

namespace BLL.Interfaces
{
    public interface IAccountService
    {
        Task RegisterAsync(RegisterDTO model);

        //
        Task<TokenDTO> LoginAsync(LoginDTO model);
        //
        Task LogoutAsync();
    }
}
