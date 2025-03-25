using BLL;
using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));


            builder.Services.ConfigurateBLL(builder.Configuration.GetConnectionString("DBConnection")!);

            var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>()!;

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(options =>
               {
                   options.Audience = jwtSettings.Audience;
                   options.Authority = jwtSettings.Audience;
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = jwtSettings.Issuer,
                       ValidAudience = jwtSettings.Audience,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Issuer)),
                       ClockSkew = TimeSpan.Zero
                   };
                   IdentityModelEventSource.ShowPII = true;
                   options.Events = new JwtBearerEvents
                   {
                       OnAuthenticationFailed = context =>
                       {
                           var token = context.Request.Cookies["jwt"];
                           return Task.CompletedTask;
                       },
                       OnMessageReceived = context =>
                       {
                           var token = context.Request.Cookies["jwt"];
                           if (!string.IsNullOrEmpty(token))
                           {
                               context.Token = token;
                           }
                           return Task.CompletedTask;
                       },
                       OnTokenValidated = context =>
                       {
                           Console.WriteLine("Token is valid.");
                           return Task.CompletedTask;
                       }
                   };
               });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("admin"));
                options.AddPolicy("Teacher", policy => policy.RequireRole("teacher"));

                options.AddPolicy("Student", policy => policy.RequireRole("student"));
                options.AddPolicy("Starosta", policy => policy.RequireRole("starosta"));


            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IAccountService, AccountService>();///удалить когда заработает

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
