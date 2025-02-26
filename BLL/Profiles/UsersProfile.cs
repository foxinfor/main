using AutoMapper;
using BLL.DTO;
using DAL.Models;

namespace BLL.Profiles
{
    class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<Users, UsersDTO>().ReverseMap();
        }
    }
}
