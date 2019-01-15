using Microsoft.AspNetCore.Identity;
using Panda.Models;
using System.Collections.Generic;

namespace Panda.Services.Contracts
{
    public interface IUsersService
    {
        User GetByUsername(string username);

        User GetByUsernameAndPassword(string username, string password);

        List<string> GetAllUsernames();

        void Register(string Username, string password, string email);
    }
}
