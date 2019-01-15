using Torshia.Models;

namespace Torshia.App.Services.Contracts
{
    public interface IUsersService
    {
        void Register(string username, string password, string email);

        User GetByUsernameAndPassword(string username, string password);
    }
}