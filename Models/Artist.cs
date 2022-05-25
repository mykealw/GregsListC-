

using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class Artist
    {
        public Artist(string name, string medium, int ears, int rate)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Medium = medium;
            this.Ears = ears;
            this.Rate = rate;
        }
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Medium { get; set; }

        [Required]
        [Range(0, 3)]
        public int Ears { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Rate { get; set; }
    }
}