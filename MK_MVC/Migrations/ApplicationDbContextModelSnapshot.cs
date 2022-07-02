﻿// <auto-generated />
using MK_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MK_MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MK_MVC.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Göteborg",
                            CountryId = 1
                        });
                });

            modelBuilder.Entity("MK_MVC.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Sweden"
                        });
                });

            modelBuilder.Entity("MK_MVC.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            LanguageName = "Swedish"
                        },
                        new
                        {
                            LanguageId = 2,
                            LanguageName = "Finnish"
                        },
                        new
                        {
                            LanguageId = 3,
                            LanguageName = "English"
                        },
                        new
                        {
                            LanguageId = 4,
                            LanguageName = "Swahili"
                        });
                });

            modelBuilder.Entity("MK_MVC.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            CityId = 1,
                            Name = "Howard Bishop",
                            Phone = "(749) 863-3748"
                        },
                        new
                        {
                            PersonId = 2,
                            CityId = 1,
                            Name = "Benny Guldfot",
                            Phone = "031-128140"
                        },
                        new
                        {
                            PersonId = 3,
                            CityId = 6,
                            Name = "Johnny Puma",
                            Phone = "128141"
                        },
                        new
                        {
                            PersonId = 4,
                            CityId = 7,
                            Name = "Alvar Aalto",
                            Phone = "128142"
                        },
                        new
                        {
                            PersonId = 5,
                            CityId = 1,
                            Name = "Kalle Kula",
                            Phone = "128143"
                        },
                        new
                        {
                            PersonId = 6,
                            CityId = 7,
                            Name = "Urho Kekkonen",
                            Phone = "128144"
                        });
                });

            modelBuilder.Entity("MK_MVC.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PersonLanguages");
                });

            modelBuilder.Entity("MK_MVC.Models.City", b =>
                {
                    b.HasOne("MK_MVC.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MK_MVC.Models.Person", b =>
                {
                    b.HasOne("MK_MVC.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MK_MVC.Models.PersonLanguage", b =>
                {
                    b.HasOne("MK_MVC.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MK_MVC.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
