using Chushka.App.Services.Contracts;
using Chushka.Data;
using Chushka.Models;
using Chushka.Models.Enums;
using SIS.MvcFramework.Services;
using System.Linq;

namespace Chushka.App.Services
{
    class UsersService : IUsersService
    {
        private readonly ChushkaDbContext dbContext;

        private readonly IHashService hashService;

        public UsersService(ChushkaDbContext dbContext, IHashService hashService)
        {
            this.dbContext = dbContext;
            this.hashService = hashService;
        }

        public User GetByUsername(string username)
        {
            return this.dbContext.Users.FirstOrDefault(x => x.Username == username);
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            string hashedPassword = this.hashService.Hash(password);

            return this.dbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);
        }

        public void Register(string username, string password, string fullName, string email)
        {
            string hashedPassword = this.hashService.Hash(password);
            UserRole role = this.dbContext.Users.Any() ? UserRole.User : UserRole.Admin;

            var user = new User
            {
                Email = email,
                FullName = fullName,
                Password = hashedPassword,
                Role = role,
                Username = username,
            };

            this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();
        }
    }
}
