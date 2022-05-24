

using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class House
    {

        public House(string description, int bedroom, int bathroom, int price, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Description = description;
            Bedroom = bedroom;
            Bathroom = bathroom;
            Price = price;
            ImgUrl = imgUrl;

        }
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(150)]
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Bedroom { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Bathroom { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(60)]
        public string ImgUrl { get; set; }
    }
}