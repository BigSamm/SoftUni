namespace PandaWebApp.Services
{
    using Contracts;
    using PandaWebApp.Data;
    using PandaWebApp.Models;
    using PandaWebApp.Models.Enums;
    using SIS.MvcFramework.Services;
    using System.Collections.Generic;
    using System.Linq;

    public class UsersService : IUsersService
    {
        private readonly PandaDbContext dbContext;

        private readonly IHashService hashService;

        public UsersService(PandaDbContext dbContext, IHashService hashService)
        {
            this.dbContext = dbContext;
            this.hashService = hashService;
        }

        public List<string> GetAllUsernames()
        {
            return this.dbContext.Users.Select(x => x.Username).ToList();
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

        public void Register(string username, string password, string email)
        {
            string hashedPassword = this.hashService.Hash(password);
            UserRole role = this.dbContext.Users.Any() ? UserRole.User : UserRole.Admin;

            var user = new User
            {
                Email = email,
                Password = hashedPassword,
                Role = role,
                Username = username,
            };

            this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();
        }
    }
}
