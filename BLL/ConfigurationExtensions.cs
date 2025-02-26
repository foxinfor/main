using BLL.Interfaces;
using BLL.Profiles;
using BLL.Services;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigurateBLL(this IServiceCollection services, string connection)
        {
            services.ConfigureDAL(connection);
            services.AddAutoMapper(typeof(UsersProfile));
            services.AddTransient<IUserService, UsersService>();
        }
    }
}
