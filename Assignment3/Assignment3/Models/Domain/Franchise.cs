using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.Domain
{
    public class Franchise
    {
        // PK
        public int Id { get; set; }

        // Properties
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }

        // Relationships
        public ICollection<Movie> Movies { get; set; }
    }
}
