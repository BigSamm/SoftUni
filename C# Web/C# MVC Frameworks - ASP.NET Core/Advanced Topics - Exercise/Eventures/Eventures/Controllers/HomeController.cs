using Microsoft.AspNetCore.Mvc;

namespace Eventures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
                return base.View("LoggedInIndex");

            return base.View();
        }
    }
}
