using Eventures.Filters;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;
        private readonly ILogger<EventsController> logger;

        public EventsController(IEventsService eventsService, ILogger<EventsController> logger)
        {
            this.eventsService = eventsService;
            this.logger = logger;
        }

        [Authorize]
        public IActionResult All()
        {
            IEnumerable<Event> dbEvents = this.eventsService.GetAll();
            var eventViewModels = new List<EventAllViewModel>();

            foreach (Event item in dbEvents)
            {
                eventViewModels.Add(new EventAllViewModel
                {
                    Id = item.Id,
                    End = item.End,
                    Name = item.Name,
                    Start = item.Start,
                });
            }

            var viewModel = new AllEventsViewModel { Events = eventViewModels };

            return View(viewModel);
        }

        [Authorize]
        public IActionResult My()
        {
            IEnumerable<Event> dbEvents = this.eventsService.GetAllByUsername(this.User.Identity.Name);
            var eventViewModels = new List<EventMyViewModel>();

            foreach (Event item in dbEvents)
            {
                eventViewModels.Add(new EventMyViewModel
                {
                    End = item.End,
                    Name = item.Name,
                    Start = item.Start,
                    Tickets = item.Orders.Where(x => x.Customer.UserName == this.User.Identity.Name).Sum(x => x.TicketsCount),
                });
            }

            var viewModel = new MyEventsViewModel { Events = eventViewModels };

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ServiceFilter(typeof(AdminCreateEventActionFilter))]
        public IActionResult Create(EventCreateViewModel model)
        {
            var @event = new Event
            {
                End = model.End,
                Name = model.Name,
                Place = model.Place,
                PricePerTicket = model.PricePerTicket,
                Start = model.Start,
                TotalTickets = model.TotalTickets,
            };

            this.eventsService.Create(@event);

            this.logger.LogInformation("Event created: " + @event.Name, @event);

            return base.RedirectToAction("All", "Events");
        }
    }
}