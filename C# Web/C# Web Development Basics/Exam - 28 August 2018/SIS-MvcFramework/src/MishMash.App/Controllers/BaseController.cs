using MishMash.App.Data;
using SIS.MvcFramework;

namespace MishMash.App.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.DbContext = new MishMashDbContext();
        }

        protected MishMashDbContext DbContext { get; set; }
    }
}