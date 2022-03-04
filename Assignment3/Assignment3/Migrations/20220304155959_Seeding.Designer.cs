﻿// <auto-generated />
using System;
using Assignment3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment3.Migrations
{
    [DbContext(typeof(MovieCharacterDbContext))]
    [Migration("20220304155959_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

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

            modelBuilder.Entity("Assignment3.Models.Domain.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Franchises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Star Wars is an American epic space opera multimedia franchise created by George Lucas, which began with the eponymous 1977 film and quickly became a worldwide pop-culture phenomenon. The franchise has been expanded into various films and other media, including television series, video games, novels, comic books, theme park attractions, and themed areas, comprising an all-encompassing fictional universe.",
                            Name = "Star Wars"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Lord of the Rings is a series of three epic fantasy adventure films directed by Peter Jackson, based on the novel written by J. R. R. Tolkien. The films are subtitled The Fellowship of the Ring (2001), The Two Towers (2002), and The Return of the King (2003). Produced and distributed by New Line Cinema with the co-production of WingNut Films, it is an international venture between New Zealand and the United States. The films feature an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving, Andy Serkis and Sean Bean.",
                            Name = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Home Alone is a series of American Christmas family comedy films originally created by John Hughes, and directed by Chris Columbus (1 and 2), Raja Gosnell (3), Rod Daniel (4), Peter Hewitt (5), and Dan Mazer (6). The films revolve around the adventures surrounding children who find themselves alone during the holiday season and are faced with the challenge of defending their family's house or themselves from invading burglars and criminals.",
                            Name = "Home Alone"
                        });
                });

            modelBuilder.Entity("Assignment3.Models.Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Picture")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Trailer")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "George Lucas",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                            ReleaseYear = 1999,
                            Title = "Star Wars: Episode I - The Phantom Menace",
                            Trailer = "https://www.youtube.com/watch?v=bD7bpG-zDJQ"
                        },
                        new
                        {
                            Id = 2,
                            Director = "George Lucas",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/3/32/Star_Wars_-_Episode_II_Attack_of_the_Clones_%28movie_poster%29.jpg",
                            ReleaseYear = 2002,
                            Title = "Star Wars: Episode II - Attack of the Clones",
                            Trailer = "https://www.youtube.com/watch?v=gYbW1F_c9eM"
                        },
                        new
                        {
                            Id = 3,
                            Director = "George Lucas",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/9/93/Star_Wars_Episode_III_Revenge_of_the_Sith_poster.jpg",
                            ReleaseYear = 2005,
                            Title = "Star Wars: Episode III - Revenge of the Sith",
                            Trailer = "https://www.youtube.com/watch?v=5UnjrG_N8hU"
                        },
                        new
                        {
                            Id = 4,
                            Director = "George Lucas",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                            ReleaseYear = 1977,
                            Title = "Star Wars: Episode IV - A New Hope",
                            Trailer = "https://www.youtube.com/watch?v=vZ734NWnAHA"
                        },
                        new
                        {
                            Id = 5,
                            Director = "Irvin Kershner",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                            ReleaseYear = 1980,
                            Title = "Star Wars: Episode V - The Empire Strikes Back",
                            Trailer = "https://www.youtube.com/watch?v=JNwNXF9Y6kY"
                        },
                        new
                        {
                            Id = 6,
                            Director = "Richard Marquand",
                            FranchiseId = 1,
                            Genre = "Action,Adventure,Fantasy,Sci-Fi",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                            ReleaseYear = 1983,
                            Title = "Star Wars: Episode VI - Return of the Jedi",
                            Trailer = "https://www.youtube.com/watch?v=XgB4gaY2dWE"
                        },
                        new
                        {
                            Id = 7,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Action,Adventure,Drama,Fantasy",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg",
                            ReleaseYear = 2001,
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            Trailer = "https://www.youtube.com/watch?v=_nZdmwHrcnw"
                        },
                        new
                        {
                            Id = 8,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Action,Adventure,Drama,Fantasy",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/d/d0/Lord_of_the_Rings_-_The_Two_Towers_%282002%29.jpg",
                            ReleaseYear = 2002,
                            Title = "The Lord of the Rings: The Two Towers",
                            Trailer = "https://www.youtube.com/watch?v=nuTU5XcZTLA"
                        },
                        new
                        {
                            Id = 9,
                            Director = "Peter Jackson",
                            FranchiseId = 2,
                            Genre = "Action,Adventure,Drama,Fantasy",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/b/be/The_Lord_of_the_Rings_-_The_Return_of_the_King_%282003%29.jpg",
                            ReleaseYear = 2003,
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            Trailer = "https://www.youtube.com/watch?v=zckJCxYxn1g"
                        },
                        new
                        {
                            Id = 10,
                            Director = "Chris Columbus",
                            FranchiseId = 3,
                            Genre = "Comedy,Family",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/7/76/Home_alone_poster.jpg",
                            ReleaseYear = 1990,
                            Title = "Home Alone",
                            Trailer = "https://www.youtube.com/watch?v=jEDaVHmw7r4"
                        },
                        new
                        {
                            Id = 11,
                            Director = "Chris Columbus",
                            FranchiseId = 3,
                            Genre = "Adventure,Comedy,Crime,Family",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/thumb/5/50/Home_Alone_2.jpg/220px-Home_Alone_2.jpg",
                            ReleaseYear = 1992,
                            Title = "Home Alone 2: Lost in New York",
                            Trailer = "https://www.youtube.com/watch?v=5h9VDUNtoto"
                        });
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.HasKey("MoviesId", "CharactersId");

                    b.HasIndex("CharactersId");

                    b.ToTable("CharacterMovie");

                    b.HasData(
                        new
                        {
                            MoviesId = 1,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 1,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 2,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 2,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 3,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 3,
                            CharactersId = 2
                        },
                        new
                        {
                            MoviesId = 3,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 4,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 4,
                            CharactersId = 2
                        },
                        new
                        {
                            MoviesId = 4,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 5,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 5,
                            CharactersId = 2
                        },
                        new
                        {
                            MoviesId = 5,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 6,
                            CharactersId = 1
                        },
                        new
                        {
                            MoviesId = 6,
                            CharactersId = 2
                        },
                        new
                        {
                            MoviesId = 6,
                            CharactersId = 3
                        },
                        new
                        {
                            MoviesId = 7,
                            CharactersId = 4
                        },
                        new
                        {
                            MoviesId = 7,
                            CharactersId = 5
                        },
                        new
                        {
                            MoviesId = 7,
                            CharactersId = 6
                        },
                        new
                        {
                            MoviesId = 8,
                            CharactersId = 5
                        },
                        new
                        {
                            MoviesId = 8,
                            CharactersId = 6
                        },
                        new
                        {
                            MoviesId = 9,
                            CharactersId = 4
                        },
                        new
                        {
                            MoviesId = 9,
                            CharactersId = 5
                        },
                        new
                        {
                            MoviesId = 9,
                            CharactersId = 6
                        },
                        new
                        {
                            MoviesId = 10,
                            CharactersId = 7
                        },
                        new
                        {
                            MoviesId = 10,
                            CharactersId = 8
                        },
                        new
                        {
                            MoviesId = 10,
                            CharactersId = 9
                        },
                        new
                        {
                            MoviesId = 11,
                            CharactersId = 7
                        },
                        new
                        {
                            MoviesId = 11,
                            CharactersId = 8
                        },
                        new
                        {
                            MoviesId = 11,
                            CharactersId = 9
                        });
                });

            modelBuilder.Entity("Assignment3.Models.Domain.Movie", b =>
                {
                    b.HasOne("Assignment3.Models.Domain.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId");

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("Assignment3.Models.Domain.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment3.Models.Domain.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Assignment3.Models.Domain.Franchise", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}