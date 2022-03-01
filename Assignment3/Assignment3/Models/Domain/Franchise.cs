using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.Domain
{
    public class Franchise
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
