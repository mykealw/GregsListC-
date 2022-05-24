using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class Car
    {

        public Car( string model, string make, int year, string color, int price, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Model = model;
            Make = make;
            Year = year;
            Color = color;
            Price = price;
            ImgUrl = imgUrl;

        }
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Make { get; set; }
        [Required]
        [Range(1950, 2023)]
        public int Year { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Color { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string ImgUrl { get; set; }
    }
}