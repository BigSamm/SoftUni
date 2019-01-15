using System.Collections.Generic;

namespace Torshia.App.ViewModels.Tasks
{
    public class TaskIndexRowViewModel
    {
        public TaskIndexRowViewModel()
        {
            this.Tasks = new List<TaskIndexViewModel>();
        }

        public List<TaskIndexViewModel> Tasks { get; set; }

        public string[] Empty => new string[5 - this.Tasks.Count];
    }
}
