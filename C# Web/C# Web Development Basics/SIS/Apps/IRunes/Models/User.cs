namespace IRunes.Models
{
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public class User : IUser
    {
        [Key]
        public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}