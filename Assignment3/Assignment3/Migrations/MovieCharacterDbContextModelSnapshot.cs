﻿// <auto-generated />
using Assignment3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment3.Migrations
{
    [DbContext(typeof(MovieCharacterDbContext))]
    partial class MovieCharacterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment3.Models.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Darth Vader",
                            Gender = "Male",
                            Name = "Anakin Skywalker",
                            Picture = "https://img.buzzfeed.com/buzzfeed-static/static/2017-04/16/12/asset/buzzfeed-prod-fastlane-02/sub-buzz-24075-1492359365-1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Gender = "Male",
                            Name = "Luke Skywalker",
                            Picture = "https://www.meme-arsenal.com/memes/c8e524b0b8bdcaed3b70bb345cd0e908.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Ben Kenobi",
                            Gender = "Male",
                            Name = "Obi-Wan Kenobi",
                            Picture = "https://i.kym-cdn.com/entries/icons/mobile/000/024/965/well.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Gender = "Male",
                            Name = "Bilbo Baggins",
                            Picture = "https://static3.srcdn.com/wordpress/wp-content/uploads/2018/01/Bilbo-in-Fellowship-of-the-Ring.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Gender = "Male",
                            Name = "Frodo Baggins",
                            Picture = "https://en.meming.world/images/en/8/8e/All_Right_Then%2C_Keep_Your_Secrets.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Alias = "Gollum",
                            Gender = "Gollum",
                            Name = "Sméagol",
                            Picture = "https://i.kym-cdn.com/entries/icons/original/000/019/367/gollum_395_394.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Gender = "Male",
                            Name = "Kevin McCallister",
                            Picture = "https://images0.persgroep.net/rcs/OEtfvPQu1Jbi2gg2oWKZcKcbxOM/diocontent/109256902/_fill/597/900/?appId=21791a8992982cd8da851550a453bd7f&quality=0.9"
                        },
                        new
                        {
                            Id = 8,
                            Alias = "Wet Bandit",
                            Gender = "Male",
                            Name = "Harry Lyme",
                            Picture = "https://www.nme.com/wp-content/uploads/2016/09/2015_HomeAlone_13_111615-2.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Alias = "Wet Bandit",
                            Gender = "Male",
                            Name = "Marv Murchins",
                            Picture = "https://www.cheatsheet.com/wp-content/uploads/2017/12/home-alone-iron.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
