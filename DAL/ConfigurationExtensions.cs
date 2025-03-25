using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureDAL(this IServiceCollection services, string connection)
        {

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            services.AddIdentity<Users, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IAttendanceRepository, AttendanceRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();


        }
    }
}
