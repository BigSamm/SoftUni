using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.ViewModels.Events
{
    public class EventCreateViewModel
    {
        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime End { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal PricePerTicket { get; set; }
    }
}
