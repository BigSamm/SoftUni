using Chushka.Models;

namespace Chushka.App.Services.Contracts
{
    public interface IUsersService
    {
        User GetByUsername(string username);

        User GetByUsernameAndPassword(string username, string password);

        void Register(string username, string password, string fullName, string email);
    }
}
