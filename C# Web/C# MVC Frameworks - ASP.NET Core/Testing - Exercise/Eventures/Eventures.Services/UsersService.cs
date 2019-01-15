using AutoMapper;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Services
{
    public class UsersService : IUsersService
    {
        private readonly SignInManager<EventuresUser> signInManager;
        private readonly UserManager<EventuresUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;

        public UsersService(
            SignInManager<EventuresUser> signInManager,
            UserManager<EventuresUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        public SignInResult Login(UserLoginViewModel model)
        {
            EventuresUser user = this.userManager.Users.FirstOrDefault(x => x.UserName == model.Username);
            if (user == null)
                return SignInResult.Failed;

            SignInResult result = this.signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;
            return result;
        }

        public IdentityResult Register(UserRegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
                return IdentityResult.Failed(new IdentityError());

            EventuresUser user = this.mapper.Map<EventuresUser>(model);
            IdentityResult result = this.userManager.CreateAsync(user, model.Password).Result;

            if (result.Succeeded)
            {
                if (this.userManager.Users.Count() == 1)
                    this.userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
                else
                    this.userManager.AddToRoleAsync(user, "User").GetAwaiter().GetResult();

                return IdentityResult.Success;
            }

            return IdentityResult.Failed(new IdentityError());
        }
        
        public IEnumerable<UserViewModel> GetAllByRole(string role)
        {
            var users = this.userManager
                .GetUsersInRoleAsync(role).GetAwaiter().GetResult()
                .Select(user => this.mapper.Map<UserViewModel>(user));

            return users;
        }

        public void Demote(string id)
        {
            var user = this.userManager.Users.First(x => x.Id == id);

            this.userManager.RemoveFromRoleAsync(user, "Admin").GetAwaiter().GetResult();
            this.userManager.AddToRoleAsync(user, "User").GetAwaiter().GetResult();
        }

        public void Promote(string id)
        {
            var user = this.userManager.Users.First(x => x.Id == id);

            this.userManager.RemoveFromRoleAsync(user, "User").GetAwaiter().GetResult();
            this.userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
        }
    }
}
