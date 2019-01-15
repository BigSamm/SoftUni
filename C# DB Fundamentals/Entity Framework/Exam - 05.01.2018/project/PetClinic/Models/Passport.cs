namespace PetClinic.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Passport
    {
        [Key]
        [MinLength(10), MaxLength(10)]
        public string SerialNumber { get; set; }

        [Required]
        public string OwnerPhoneNumber { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        public string OwnerName { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public Animal Animal { get; set; }
    }
}
