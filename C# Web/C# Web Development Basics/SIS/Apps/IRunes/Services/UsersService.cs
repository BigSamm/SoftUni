namespace IRunes.Services
{
    using System;
    using System.Linq;

    using Contracts;
    using Data;
    using Models;
    using global::Services.Contracts;

    public class UsersService : IUsersService
    {
        private readonly IRunesDbContext dbContext;

        private IHashService hashService;

        public UsersService(IRunesDbContext context, IHashService hashService)
        {
            this.dbContext = context;
            this.hashService = hashService;
        }

        public bool ExistsByUsernameAndPassword(string username, string password)
        {
            string hashedPassword = this.hashService.Hash(password);

            bool userExists = this.dbContext.Users.Any(x => x.Username == username && x.Password == hashedPassword);

            return userExists;
        }

        public bool ExistsByEmail(string emial)
        {
            bool emailExists = this.dbContext.Users.Any(x => x.Email == emial);
            return emailExists;
        }

        public bool AreSamePasswords(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        public bool TryAddToDatabase(string username, string password, string email)
        {
            string hashedPassword = this.hashService.Hash(password);

            var user = new User
            {
                Username = username,
                Password = hashedPassword,
                Email = email
            };

            this.dbContext.Users.Add(user);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}