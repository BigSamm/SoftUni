using MishMash.App.Models.Base;

namespace MishMash.App.Models
{
    public class Tag : BaseModel<int>
    {
        public string Name { get; set; }
    }
}