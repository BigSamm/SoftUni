using SIS.Framework.ActionResults;
using SIS.Framework.Attributes.Method;
using System;
using System.Globalization;
using System.Linq;
using Torshia.App.Controllers.Base;
using Torshia.App.Services.Contracts;
using Torshia.App.ViewModels.Tasks;
using Torshia.Models;

namespace Torshia.App.Controllers
{
    public class TasksController : BaseController
    {
        private readonly ITasksService tasksService;

        public TasksController(ITasksService tasksService)
        {
            this.tasksService = tasksService;
        }

        public IActionResult Create()
        {
            return base.View();
        }
        
        [HttpPost]
        public IActionResult Create(TaskCreateViewModel model)
        {
            this.tasksService.Register(model.Title, model.DueDate, model.Description, model.Participants, model.AffectedSectors);

            return base.RedirectToAction("/");
        }
        
        public IActionResult Details(int id)
        {
            Task task = this.tasksService.GetById(id);

            if (task == null)
                return base.RedirectToAction("/");

            var viewModel = new TaskDetailsViewModel
            {
                AffectedSectors = String.Join(", ", task.AffectedSectors.Select(x => x.Sector.ToString())),
                Description = task.Description,
                DueDate = task.DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                Participants = String.Join(", ", task.Participants.Select(x => x.Content)),
                Title = task.Title,
                Level = task.Level,
            };

            base.Model["Task"] = viewModel;

            return base.View();
        }
    }
}