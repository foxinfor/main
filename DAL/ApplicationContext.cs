using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DAL
{
    public class ApplicationContext : IdentityDbContext<Users>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "ADMIN";

            var teacher = new IdentityRole("teacher");
            teacher.NormalizedName = "TEACHER";

            var student = new IdentityRole("student");
            student.NormalizedName = "STUDENT";

            var starosta = new IdentityRole("starosta");
            starosta.NormalizedName = "STAROSTA";

            builder.Entity<IdentityRole>().HasData(admin, teacher, student, starosta);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }


        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Subject> Subject { get; set; }

        public DbSet<Users> Users { get; set; }//хз 
    }
}
