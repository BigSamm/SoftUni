using System.Collections.Generic;

namespace Eventures.ViewModels.Users
{
    public class UsersAdministrationViewModel
    {
        public IEnumerable<UserViewModel> Admins { get; set; }

        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
