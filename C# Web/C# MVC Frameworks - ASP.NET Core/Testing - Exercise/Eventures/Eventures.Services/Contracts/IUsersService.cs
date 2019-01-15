using Eventures.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IUsersService
    {
        SignInResult Login(UserLoginViewModel model);

        IdentityResult Register(UserRegisterViewModel model);

        IEnumerable<UserViewModel> GetAllByRole(string role);

        void Demote(string id);

        void Promote(string id);
    }
}
