using Chushka.Services.Contracts;
using Chushka.Data;
using Chushka.Models;
using Chushka.Models.Enums;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Chushka.Services
{
    public class UsersService : IUsersService
    {
        private readonly ChushkaDbContext dbContext;

        private readonly IPasswordHasher<ChushkaUser> passwordHasher;

        public UsersService(ChushkaDbContext dbContext, IPasswordHasher<ChushkaUser> passwordHasher)
        {
            this.dbContext = dbContext;
            this.passwordHasher = passwordHasher;
        }

        public ChushkaUser GetByUsername(string username)
        {
            return this.dbContext.Users.FirstOrDefault(x => x.UserName == username);
        }

        public ChushkaUser GetByUsernameAndPassword(string username, string password)
        {
            ChushkaUser user = this.GetByUsername(username);
            string hashedPassword = this.passwordHasher.HashPassword(user, password);

            return this.dbContext.Users.FirstOrDefault(x => x.UserName == username && x.PasswordHash == hashedPassword);
        }

        public void Register(string username, string password, string fullName, string email)
        {
            //UserRole role = this.dbContext.Users.Any() ? UserRole.User : UserRole.Admin;

            //var user = new ChushkaUser
            //{
            //    Email = email,
            //    FullName = fullName,
            //    PasswordHash = this.passwordHasher.HashPassword(user, password),
            //    Role = role,
            //    Username = username,
            //};

            //this.dbContext.Users.Add(user);
            //this.dbContext.SaveChanges();
        }
    }
}
