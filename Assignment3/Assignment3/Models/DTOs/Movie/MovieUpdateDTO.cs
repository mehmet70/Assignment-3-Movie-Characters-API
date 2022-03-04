using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.DTOs.Movie
{
    public class MovieUpdateDTO
    {
        // PK
        public int Id { get; set; }

        // Properties
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Genre { get; set; }
        public int? ReleaseYear { get; set; }
        [MaxLength(100)]
        public string Director { get; set; }
        [Url]
        [MaxLength(500)]
        public string Picture { get; set; }
        [Url]
        [MaxLength(500)]
        public string Trailer { get; set; }
    }
}
