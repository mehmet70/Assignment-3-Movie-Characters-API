using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.DTOs.Franchise
{
    public class FranchiseCreateDTO
    {
        // Properties
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
    }
}
