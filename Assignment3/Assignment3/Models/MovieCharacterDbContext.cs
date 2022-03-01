using Assignment3.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class MovieCharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Franchise> Franchises { get; set; }

        public MovieCharacterDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Characters

            #region Star Wars

            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 1,
                Name = "Anakin Skywalker",
                Alias = "Darth Vader",
                Gender = "Male",
                Picture = "https://img.buzzfeed.com/buzzfeed-static/static/2017-04/16/12/asset/buzzfeed-prod-fastlane-02/sub-buzz-24075-1492359365-1.jpg"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 2,
                Name = "Luke Skywalker",
                Gender = "Male",
                Picture = "https://www.meme-arsenal.com/memes/c8e524b0b8bdcaed3b70bb345cd0e908.jpg"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 3,
                Name = "Obi-Wan Kenobi",
                Alias = "Ben Kenobi",
                Gender = "Male",
                Picture = "https://i.kym-cdn.com/entries/icons/mobile/000/024/965/well.jpg"
            });

            #endregion

            # region The Lord of the Rings

            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 4,
                Name = "Bilbo Baggins",
                Gender = "Male",
                Picture = "https://static3.srcdn.com/wordpress/wp-content/uploads/2018/01/Bilbo-in-Fellowship-of-the-Ring.jpg"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 5,
                Name = "Frodo Baggins",
                Gender = "Male",
                Picture = "https://en.meming.world/images/en/8/8e/All_Right_Then%2C_Keep_Your_Secrets.jpg"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 6,
                Name = "Sméagol",
                Alias = "Gollum",
                Gender = "Gollum",
                Picture = "https://i.kym-cdn.com/entries/icons/original/000/019/367/gollum_395_394.jpg"
            });

            #endregion

            #region Home Alone

            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 7,
                Name = "Kevin McCallister",
                Gender = "Male",
                Picture = "https://images0.persgroep.net/rcs/OEtfvPQu1Jbi2gg2oWKZcKcbxOM/diocontent/109256902/_fill/597/900/?appId=21791a8992982cd8da851550a453bd7f&quality=0.9"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 8,
                Name = "Harry Lyme",
                Alias = "Wet Bandit",
                Gender = "Male",
                Picture = "https://www.nme.com/wp-content/uploads/2016/09/2015_HomeAlone_13_111615-2.jpg"
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 9,
                Name = "Marv Murchins",
                Alias = "Wet Bandit",
                Gender = "Male",
                Picture = "https://www.cheatsheet.com/wp-content/uploads/2017/12/home-alone-iron.jpg"
            });

            #endregion

            #endregion


            #region Movies

            #region Star Wars

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                Title = "Star Wars: Episode I - The Phantom Menace",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 1999,
                Director = "George Lucas",
                Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                Trailer = "https://www.youtube.com/watch?v=bD7bpG-zDJQ"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Title = "Star Wars: Episode II - Attack of the Clones",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 2002,
                Director = "George Lucas",
                Picture = "https://upload.wikimedia.org/wikipedia/en/3/32/Star_Wars_-_Episode_II_Attack_of_the_Clones_%28movie_poster%29.jpg",
                Trailer = "https://www.youtube.com/watch?v=gYbW1F_c9eM"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Title = "Star Wars: Episode III - Revenge of the Sith",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 2005,
                Director = "George Lucas",
                Picture = "https://upload.wikimedia.org/wikipedia/en/9/93/Star_Wars_Episode_III_Revenge_of_the_Sith_poster.jpg",
                Trailer = "https://www.youtube.com/watch?v=5UnjrG_N8hU"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Title = "Star Wars: Episode IV - A New Hope",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 1977,
                Director = "George Lucas",
                Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                Trailer = "https://www.youtube.com/watch?v=vZ734NWnAHA"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Title = "Star Wars: Episode V - The Empire Strikes Back",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 1980,
                Director = "Irvin Kershner",
                Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                Trailer = "https://www.youtube.com/watch?v=JNwNXF9Y6kY"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 6,
                Title = "Star Wars: Episode VI - Return of the Jedi",
                Genre = "Action,Adventure,Fantasy,Sci-Fi",
                ReleaseYear = 1983,
                Director = "Richard Marquand",
                Picture = "https://upload.wikimedia.org/wikipedia/en/4/40/Star_Wars_Phantom_Menace_poster.jpg?20181008114735",
                Trailer = "https://www.youtube.com/watch?v=XgB4gaY2dWE"
            });

            #endregion

            #region The Lord of the Rings

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 7,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Genre = "Action,Adventure,Drama,Fantasy",
                ReleaseYear = 2001,
                Director = "Peter Jackson",
                Picture = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg",
                Trailer = "https://www.youtube.com/watch?v=_nZdmwHrcnw"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 8,
                Title = "The Lord of the Rings: The Two Towers",
                Genre = "Action,Adventure,Drama,Fantasy",
                ReleaseYear = 2002,
                Director = "Peter Jackson",
                Picture = "https://upload.wikimedia.org/wikipedia/en/d/d0/Lord_of_the_Rings_-_The_Two_Towers_%282002%29.jpg",
                Trailer = "https://www.youtube.com/watch?v=nuTU5XcZTLA"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 9,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Genre = "Action,Adventure,Drama,Fantasy",
                ReleaseYear = 2003,
                Director = "Peter Jackson",
                Picture = "https://upload.wikimedia.org/wikipedia/en/b/be/The_Lord_of_the_Rings_-_The_Return_of_the_King_%282003%29.jpg",
                Trailer = "https://www.youtube.com/watch?v=zckJCxYxn1g"
            });

            #endregion

            #region Home Alone

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 10,
                Title = "Home Alone",
                Genre = "Comedy,Family",
                ReleaseYear = 1990,
                Director = "Chris Columbus",
                Picture = "https://upload.wikimedia.org/wikipedia/en/7/76/Home_alone_poster.jpg",
                Trailer = "https://www.youtube.com/watch?v=jEDaVHmw7r4"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 11,
                Title = "Home Alone 2: Lost in New York",
                Genre = "Adventure,Comedy,Crime,Family",
                ReleaseYear = 1992,
                Director = "Chris Columbus",
                Picture = "https://upload.wikimedia.org/wikipedia/en/thumb/5/50/Home_Alone_2.jpg/220px-Home_Alone_2.jpg",
                Trailer = "https://www.youtube.com/watch?v=5h9VDUNtoto"
            });

            #endregion

            #endregion


            #region Franchises

            #region Star Wars
            
            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                Id = 1,
                Name = "Star Wars",
                Description = "Star Wars is an American epic space opera multimedia franchise created by George Lucas, which began with the eponymous 1977 film " +
                "and quickly became a worldwide pop-culture phenomenon. The franchise has been expanded into various films and other media, including television series, " +
                "video games, novels, comic books, theme park attractions, and themed areas, comprising an all-encompassing fictional universe."
            });

            #endregion

            #region The Lord of the Rings

            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                Id = 2,
                Name = "The Lord of the Rings",
                Description = "The Lord of the Rings is a series of three epic fantasy adventure films directed by Peter Jackson, based on the novel written by J. R. R. Tolkien. " +
                "The films are subtitled The Fellowship of the Ring (2001), The Two Towers (2002), and The Return of the King (2003). " +
                "Produced and distributed by New Line Cinema with the co-production of WingNut Films, it is an international venture between New Zealand and the United States. " +
                "The films feature an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, " +
                "Christopher Lee, Billy Boyd, Dominic Monaghan, Orlando Bloom, Hugo Weaving, Andy Serkis and Sean Bean."
            });

            #endregion

            #region Home Alone

            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                Id = 3,
                Name = "Home Alone",
                Description = "Home Alone is a series of American Christmas family comedy films originally created by John Hughes, and directed by Chris Columbus (1 and 2), " +
                "Raja Gosnell (3), Rod Daniel (4), Peter Hewitt (5), and Dan Mazer (6). The films revolve around the adventures surrounding children who find themselves alone " +
                "during the holiday season and are faced with the challenge of defending their family's house or themselves from invading burglars and criminals."
            });

            #endregion

            #endregion
        }
    }
}
