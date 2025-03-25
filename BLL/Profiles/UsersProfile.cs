using AutoMapper;
using BLL.DTO;
using DAL.Models;

namespace BLL.Profiles
{
    class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<RegisterDTO, Users>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));
        }
    }
}
