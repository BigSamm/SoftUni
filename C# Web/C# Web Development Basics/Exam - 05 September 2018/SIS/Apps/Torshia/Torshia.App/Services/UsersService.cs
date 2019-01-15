using System.Linq;
using Torshia.App.Services.Contracts;
using Torshia.Data;
using Torshia.Models;
using Torshia.Models.Enums;

namespace Torshia.App.Services
{
    public class UsersService : IUsersService
    {
        private readonly TorshiaDbContext dbContext;

        public UsersService(TorshiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            return this.dbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public void Register(string username, string password, string email)
        {
            UserRole role = this.dbContext.Users.Any() ? UserRole.User : UserRole.Admin;
             
            var user = new User
            {
                Email = email,
                Password = password,
                Username = username,
                Role = role,
            };

            this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();
        }
    }
}