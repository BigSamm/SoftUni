using System.ComponentModel.DataAnnotations;

namespace MishMash.App.ViewModels.Users
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
    }
}