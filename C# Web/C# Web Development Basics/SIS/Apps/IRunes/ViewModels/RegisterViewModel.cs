namespace IRunes.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        public string Username { get; set; }
    
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
        
        public string Email { get; set; }
    }
}