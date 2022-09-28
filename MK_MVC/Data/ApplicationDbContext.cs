using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MK_MVC.Models;
using System;

namespace MK_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, CountryName = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, CountryName = "Iceland" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, CountryName = "Finland" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, CountryName = "Great Britain" });

            modelBuilder.Entity<City>().HasData(new City { CityId = 1, CityName = "Göteborg", CountryId = 1 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 2, CityName = "Reykjavik", CountryId = 2 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 3, CityName = "Helsinki", CountryId = 3 });
            modelBuilder.Entity<City>().HasData(new City { CityId = 4, CityName = "Leeds", CountryId = 4 });

            

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

            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, Name = "Howard Bishop", Phone = "(749) 863-3748", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, Name = "Benny Guldfot", Phone = "031-128140", CityId = 1 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, Name = "Johnny Puma", Phone = "128141", CityId = 2 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, Name = "Alvar Aalto", Phone = "128142", CityId = 3 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 5, Name = "Kalle Kula", Phone = "128143", CityId = 4 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 6, Name = "Urho Kekkonen", Phone = "128144", CityId = 3 });

            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 1, PersonId = 2 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 3, PersonId = 1 });
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 3, PersonId = 2 });

            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"

            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Ad",
                LastName = "Min",
                BirthDate = "620325",
                PasswordHash = hasher.HashPassword(null, "ego")

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId, UserId = userId
            });
        }

    }
}
    
