

using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
    public class Job
    {
        public Job(string description, string type, int salary, string title, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Description = description;
            Type = type;
            Salary = salary;
            Title = title;
            ImgUrl = imgUrl;

        }
        public string Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(150)]
        public string Description { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(150)]
        public string Type { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Salary { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(150)]
        public string ImgUrl { get; set; }
    }
}