using P01_StudentSystem.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public  class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public ResourceType ResourceType { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
