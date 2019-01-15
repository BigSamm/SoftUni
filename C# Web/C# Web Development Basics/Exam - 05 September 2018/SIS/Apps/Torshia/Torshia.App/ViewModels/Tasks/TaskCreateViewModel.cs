using System;
using System.Collections.Generic;

namespace Torshia.App.ViewModels.Tasks
{
    public class TaskCreateViewModel
    {
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public string Participants { get; set; }
        
        public List<string> AffectedSectors { get; set; }
    }
}