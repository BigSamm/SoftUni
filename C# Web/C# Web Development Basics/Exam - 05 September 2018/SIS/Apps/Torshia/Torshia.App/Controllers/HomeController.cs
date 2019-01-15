using SIS.Framework.ActionResults;
using System.Collections.Generic;
using System.Linq;
using Torshia.App.Controllers.Base;
using Torshia.App.Services.Contracts;
using Torshia.App.ViewModels.Tasks;
using Torshia.Models;

namespace Torshia.App.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ITasksService tasksService;

        public HomeController(ITasksService tasksService)
        {
            this.tasksService = tasksService;
        }

        public IActionResult Index()
        {
            if (base.Identity == null)
                return base.View();

            base.Model["Username"] = base.Identity.Username;

            List<Task> tasks = this.tasksService.GetAll();

            List<TaskIndexViewModel> taskViewModels = tasks.Select(x => new TaskIndexViewModel
            {
                Id = x.Id,
                Level = x.Level,
                Title = x.Title,
            }).ToList();

            var taskRowViewModels = new List<TaskIndexRowViewModel>();

            for (int i = 0; i < taskViewModels.Count; i++)
            {
                if (i % 5 == 0)
                    taskRowViewModels.Add(new TaskIndexRowViewModel());

                taskRowViewModels[taskRowViewModels.Count - 1].Tasks.Add(taskViewModels[i]);
            }

            base.Model["TaskRows"] = taskRowViewModels;

            if (this.Identity.Roles.Contains("Admin"))
                return this.View("Index-Admin");

            if (this.Identity.Roles.Contains("User"))
                return this.View("Index-User");

            return base.View();
        }
    }
}