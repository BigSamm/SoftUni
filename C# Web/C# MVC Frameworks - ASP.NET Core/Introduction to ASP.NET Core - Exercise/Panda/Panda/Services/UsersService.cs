namespace Panda.Services
{
    using Contracts;
    using Microsoft.AspNetCore.Identity;
    using Panda.Data;
    using Panda.Models;
    using Panda.Models.Enums;
    using System.Collections.Generic;
    using System.Linq;

    public class UsersService : IUsersService
    {
        private readonly PandaDbContext dbContext;

        private readonly IPasswordHasher<User> passwordHasher;

        public UsersService(PandaDbContext dbContext, IPasswordHasher<User> passwordHasher)
        {
            this.dbContext = dbContext;
            this.passwordHasher = passwordHasher;
        }

        public List<string> GetAllUsernames()
        {
            return this.dbContext.Users.Select(x => x.Username).ToList();
        }

        public User GetByUsername(string Username)
        {
            return this.dbContext.Users.FirstOrDefault(x => x.Username == Username);
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            User user = this.GetByUsername(username);
            string hashedPassword = this.passwordHasher.HashPassword(user, password);

            return this.dbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);
        }

        public void Register(string Username, string password, string email)
        {
            User dbUser = this.GetByUsername(Username);
            string hashedPassword = this.passwordHasher.HashPassword(dbUser, password);
            UserRole role = this.dbContext.Users.Any() ? UserRole.User : UserRole.Admin;

            var user = new User
            {
                Email = email,
                Password = hashedPassword,
                Role = role,
                Username = Username,
            };

            this.dbContext.Users.Add(dbUser);
            this.dbContext.SaveChanges();
        }
    }
}
