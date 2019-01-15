namespace CakesWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public User()
        {
            this.DateOfRegistration = DateTime.UtcNow;
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
