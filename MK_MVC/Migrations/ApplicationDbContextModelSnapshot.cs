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

            modelBuilder.Entity("MK_MVC.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            City = "Guápiles",
                            Name = "Howard Bishop",
                            Phone = "(749) 863-3748"
                        },
                        new
                        {
                            PersonId = 2,
                            City = "Valéncia",
                            Name = "Derek Dixon",
                            Phone = "(542) 246-1009"
                        },
                        new
                        {
                            PersonId = 3,
                            City = "Lauro de Freitas",
                            Name = "Nathan Gilbert",
                            Phone = "1-676-671-1754"
                        },
                        new
                        {
                            PersonId = 4,
                            City = "Uberlândia",
                            Name = "Clementine Michael",
                            Phone = "(385) 763-6528"
                        },
                        new
                        {
                            PersonId = 5,
                            City = "Canberra",
                            Name = "Elliott Carrillo",
                            Phone = "(950) 400-6396"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
