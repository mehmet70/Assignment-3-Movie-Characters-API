﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.DTOs.Character
{
    public class CharacterCreateDTO
    {
        // Properties
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Alias { get; set; }
        [MaxLength(20)]
        public string Gender { get; set; }
        [Url]
        [MaxLength(300)]
        public string Picture { get; set; }
    }
}
