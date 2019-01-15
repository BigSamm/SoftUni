using System.ComponentModel.DataAnnotations;

namespace Eventures.ViewModels.Users
{
    public class UserRegisterViewModel
    {
        [Required]
        [MinLength(3)]
        [RegularExpression("[a-zA-Z-_.*~]+")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("[0-9]{10}")]
        public string UCN { get; set; }
    }
}
