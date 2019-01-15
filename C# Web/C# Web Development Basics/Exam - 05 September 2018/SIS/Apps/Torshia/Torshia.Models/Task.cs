using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Torshia.Models.Base;

namespace Torshia.Models
{
    public class Task : BaseModel<int>
    {
        public Task()
        {
            this.Participants = new HashSet<Participant>();
            this.AffectedSectors = new HashSet<TaskSector>();
            this.Reports = new HashSet<Report>();
        }
        
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsReported { get; set; }

        public string Description { get; set; }

        [NotMapped]
        public int Level => this.AffectedSectors.Count;

        public virtual ICollection<Participant> Participants { get; set; }
        
        public virtual ICollection<TaskSector> AffectedSectors { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}