using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.Domain
{
    public class Movie
    {
        // PK
        public int Id { get; set; }

        // Properties
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        [MaxLength(100)]
        public string Director { get; set; }
        [Url]
        [MaxLength(300)]
        public string Picture { get; set; }
        [Url]
        [MaxLength(300)]
        public string Trailer { get; set; }

        // Relationships
        public ICollection<Character> Characters { get; set; }

        public int? FranchiseId { get; set; }
        public Franchise Franchise { get; set; }
    }
}
