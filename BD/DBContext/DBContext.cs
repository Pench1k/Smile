using BD.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BD.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public ApplicationDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Reception> Reception { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Specialization> Specialization { get; set; }
        public DbSet<Stomatology> Stomatology { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<WorkingHouseDoctor> WorkingHouseDoctor { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=Smile;Database=Smile;Trusted_Connection=True;");
        //}
    }
}
