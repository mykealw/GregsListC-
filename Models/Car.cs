

using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class Car
    {
        public Car(string id, string model, string make, int year, int price) 
        {
            Id = Guid.NewGuid().ToString();
    Model = model;
    Make = make;
    Year = year;
    Price = price;
   
        }
                public string Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Make {get; set; }
        [Required]
        [Range(1950, 2023)]
        public int Year { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Price {get; set; }
    }
}