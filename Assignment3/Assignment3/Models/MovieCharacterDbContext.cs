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
        }
    }
}
