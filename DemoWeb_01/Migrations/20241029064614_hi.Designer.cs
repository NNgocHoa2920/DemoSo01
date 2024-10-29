﻿// <auto-generated />
using DemoWeb_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoWeb_01.Migrations
{
    [DbContext(typeof(CategoryDbContext))]
    [Migration("20241029064614_hi")]
    partial class hi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoWeb_01.Models.Category", b =>
                {
                    b.Property<int>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Ma");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Ma = 1,
                            Description = " trắng",
                            Name = "sắn"
                        },
                        new
                        {
                            Ma = 2,
                            Description = " trắng",
                            Name = "ngô"
                        },
                        new
                        {
                            Ma = 3,
                            Description = " trắng",
                            Name = "khoai"
                        },
                        new
                        {
                            Ma = 4,
                            Description = " trắng",
                            Name = "Bắp"
                        },
                        new
                        {
                            Ma = 5,
                            Description = " trắng",
                            Name = "dứa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
