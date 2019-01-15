using System.ComponentModel.DataAnnotations;

namespace Chushka.Models.Base
{
    public abstract class BaseModel<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
