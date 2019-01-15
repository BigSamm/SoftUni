namespace IRunes.Controllers
{
    using System;
    using System.Linq;
    using System.Net;

    using Models;
    using ViewModels;
    using SIS.Framework.ActionResults.Contracts;
    using SIS.Framework.Attributes.Methods;
    using SIS.Framework.Controllers;
    using SIS.WebServer.Results;

    public class TracksController : Controller
    {
        public IActionResult Create()
        {
            return base.View();
        }

        [HttpPost]
        public IActionResult Create(CreateTrackViewModel model)
        {
            return base.View();
        }
        
        public IActionResult Details()
        {
            return base.View();
        }
    }
}