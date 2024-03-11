using LoopAcademyProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoopAcademyProject.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new ()
                {
                    Id = 1,
                    UserName = "MinaDdshi",
                    Name = "Mina",
                    SurName = "Ddshi",
                    PhoneNumber = "09367636359",
                    Birth = DateTime.Parse("1998/1/18"),
                    NationalCode = "1234567890"
                },
            });

        }
    }
}
