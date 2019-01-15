using Chushka.Models;

namespace Chushka.Services.Contracts
{
    public interface IUsersService
    {
        ChushkaUser GetByUsername(string username);

        ChushkaUser GetByUsernameAndPassword(string username, string password);

        void Register(string username, string password, string fullName, string email);
    }
}
