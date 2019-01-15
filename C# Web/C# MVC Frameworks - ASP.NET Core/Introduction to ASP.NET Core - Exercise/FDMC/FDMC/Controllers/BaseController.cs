using FDMC.Data;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.DbContext = new FDMCdbContext();
        }

        protected FDMCdbContext DbContext { get; set; }
    }
}
