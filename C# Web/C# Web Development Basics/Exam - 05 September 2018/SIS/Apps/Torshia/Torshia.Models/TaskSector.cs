using Torshia.Models.Base;
using Torshia.Models.Enums;

namespace Torshia.Models
{
    public class TaskSector : BaseModel<int>
    {
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public SectorType Sector { get; set; }
    }
}