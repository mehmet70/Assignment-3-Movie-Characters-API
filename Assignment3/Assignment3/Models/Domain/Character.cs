using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models.Domain
{
    public class Character
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Alias { get; set; }
        [MaxLength(20)]
        public string Gender { get; set; }
        [MaxLength(300)]
        public string Picture { get; set; }
    }
}
