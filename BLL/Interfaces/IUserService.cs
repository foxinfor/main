using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IUserService : IService<RegisterDTO>
    {
        public Task<RegisterDTO> FindByIdAsync(string id);

    }
}
