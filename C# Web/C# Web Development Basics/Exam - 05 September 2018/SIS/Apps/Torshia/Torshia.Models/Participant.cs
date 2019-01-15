using Torshia.Models.Base;

namespace Torshia.Models
{
    public class Participant : BaseModel<int>
    {
        public string Content { get; set; }
    }
}