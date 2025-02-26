using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureDAL(this IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IUsersRepository, UsersRepository>();
        }
    }
}
