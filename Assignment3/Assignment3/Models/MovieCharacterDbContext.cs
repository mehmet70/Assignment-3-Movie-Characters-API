using Assignment3.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class MovieCharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public MovieCharacterDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Star Wars
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

            // The Lord of the Rings
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

            // Home Alone
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
        }
    }
}
