using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.DTOs.Character
{
    public class CharacterReadDTO
    {
        // PK
        public int Id { get; set; }

        // Properties
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Alias { get; set; }
        [MaxLength(50)]
        public string Gender { get; set; }
        [Url]
        [MaxLength(500)]
        public string Picture { get; set; }

        // Relationships
        public List<int> Movies { get; set; }
    }
}
