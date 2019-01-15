using System.Linq;
using System.Runtime.CompilerServices;
using SIS.Framework.ActionResults;
using SIS.Framework.Controllers;

namespace Torshia.App.Controllers.Base
{
    public class BaseController : Controller
    {
        protected override IViewable View([CallerMemberName] string actionName = "")
        {
            base.Model["guestNavbarDisplay"] = "none";
            base.Model["userNavbarDisplay"] = "none";
            base.Model["adminNavbarDisplay"] = "none";

            if (base.Identity == null)
                base.Model["guestNavbarDisplay"] = "flex";
            else if (base.Identity != null && base.Identity.Roles.Contains("User"))
                base.Model["userNavbarDisplay"] = "flex";
            else if (base.Identity != null && base.Identity.Roles.Contains("Admin"))
                base.Model["adminNavbarDisplay"] = "flex";

            return base.View(actionName);
        }
    }
}