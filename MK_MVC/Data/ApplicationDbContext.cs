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
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<PersonLanguage> PersonLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "Sweden" });


            modelBuilder.Entity<City>().HasData(new City { CityId = 1, CityName = "Göteborg", CountryId = 1 });

            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, Name = "Howard Bishop", Phone = "(749) 863-3748", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, Name = "Benny Guldfot", Phone = "031-128140", CityId = 1 });

            modelBuilder.Entity<PersonLanguage>().HasKey(pl => new { pl.PersonId, pl.LanguageId });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Language)
                .WithMany(l => l.PersonLanguages)
                .HasForeignKey(pl => pl.LanguageId);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Person)
                .WithMany(p => p.PersonLanguages)
                .HasForeignKey(pl => pl.PersonId);
            
                        modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 1, LanguageName = "Swedish" });
                        modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 2, LanguageName = "Finnish" });
                        modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 3, LanguageName = "English" });
                        modelBuilder.Entity<Language>().HasData(new Language { LanguageId = 4, LanguageName = "Swahili" });
           
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, Name = "Johnny Puma", Phone = "128141", CityId = 6 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, Name = "Alvar Aalto", Phone = "128142", CityId = 7 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 5, Name = "Kalle Kula", Phone = "128143", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 6, Name = "Urho Kekkonen", Phone = "128144", CityId = 7 });


        }

    }
}
    
