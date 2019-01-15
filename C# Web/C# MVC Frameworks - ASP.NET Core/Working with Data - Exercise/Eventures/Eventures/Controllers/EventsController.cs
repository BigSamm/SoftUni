using Eventures.Filters;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
            var eventViewModels = new List<EventInfoViewModel>();

            foreach (Event item in dbEvents)
            {
                eventViewModels.Add(new EventInfoViewModel
                {
                    End = item.End,
                    Name = item.Name,
                    Place = item.Place,
                    Start = item.Start,
                });
            }

            var viewModel = new AllEventsViewModel { Events = eventViewModels };

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