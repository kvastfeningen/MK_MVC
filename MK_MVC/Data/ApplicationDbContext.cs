using Microsoft.EntityFrameworkCore;
using MK_MVC.Models;

namespace MK_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1 , Name = "Howard Bishop", Phone = "(749) 863-3748", City = "Guápiles" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, Name = "Derek Dixon", Phone = "(542) 246-1009", City = "Valéncia" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, Name = "Nathan Gilbert", Phone = "1-676-671-1754", City = "Lauro de Freitas" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, Name = "Clementine Michael", Phone = "(385) 763-6528", City = "Uberlândia" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 5, Name = "Elliott Carrillo", Phone = "(950) 400-6396", City = "Canberra" });
        }

    }
}
