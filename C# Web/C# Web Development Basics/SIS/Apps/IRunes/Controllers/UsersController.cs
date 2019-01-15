namespace IRunes.Controllers
{
    using Services.Contracts;
    using ViewModels;
    using SIS.Framework.ActionResults.Contracts;
    using SIS.Framework.Attributes.Methods;
    using SIS.Framework.Controllers;
    using SIS.Framework.Security;
    using SIS.Framework.Attributes.Action;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IActionResult Index()
        {
            return base.View();
        }

        public IActionResult Login()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            string username = base.Request.FormData["username"].ToString();
            string password = base.Request.FormData["password"].ToString();

            if (!ModelState.IsValid.HasValue || !ModelState.IsValid.Value)
                return this.RedirectToAction("/Users/Login");

            bool userExists = this.usersService.ExistsByUsernameAndPassword(username, password);
            if (!userExists)
                return this.RedirectToAction("/Users/Login");

            base.SignIn(new IdentityUser
            {
                Username = username,
                Password = password
            });

            return base.RedirectToAction("/");
        }

        public IActionResult Register()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            string username = base.Request.FormData["username"].ToString();
            string password = base.Request.FormData["password"].ToString();
            string confirmPassword = base.Request.FormData["confirmPassword"].ToString();
            string email = base.Request.FormData["email"].ToString();

            if (!ModelState.IsValid.HasValue || !ModelState.IsValid.Value)
                return this.RedirectToAction("/Users/Login");

            bool userExistsByUsername = this.usersService.ExistsByUsernameAndPassword(username, password);
            bool userExistsByEmail = this.usersService.ExistsByEmail(email);
            if (userExistsByUsername || userExistsByEmail)
                return base.RedirectToAction("/Users/Login");

            bool areSamePasswords = this.usersService.AreSamePasswords(password, confirmPassword);
            if (!areSamePasswords)
                return base.RedirectToAction("Users/Login");

            bool isSuccessfully = this.usersService.TryAddToDatabase(username, password, email);
            if (!isSuccessfully)
                return base.RedirectToAction("Users/Login");

            base.SignIn(new IdentityUser
            {
                Username = username,
                Password = password,
                Email = email
            });

            return base.RedirectToAction("/");
        }

        [Authorize]
        public IActionResult Authorized()
        {
            base.ViewModel["username"] = base.Identity.Username;
            return base.View();
        }
    }
}