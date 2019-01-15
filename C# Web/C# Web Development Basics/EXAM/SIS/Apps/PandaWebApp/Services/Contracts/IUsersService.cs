using PandaWebApp.Models;
using System.Collections.Generic;

namespace PandaWebApp.Services.Contracts
{
    public interface IUsersService
    {
        User GetByUsername(string username);

        User GetByUsernameAndPassword(string username, string password);

        List<string> GetAllUsernames();

        void Register(string username, string password, string email);
    }
}
