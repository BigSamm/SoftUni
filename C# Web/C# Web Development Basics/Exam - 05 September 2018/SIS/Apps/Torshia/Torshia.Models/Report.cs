using System;
using Torshia.Models.Base;
using Torshia.Models.Enums;

namespace Torshia.Models
{
    public class Report : BaseModel<int>
    {
        public ReportStatus Status { get; set; }

        public DateTime ReportedOn { get; set; }

        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public string ReporterId { get; set; }
        public virtual User Reporter { get; set; }        
    }
}