using AutoMapper;
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
        private readonly IMapper mapper;

        public EventsController(IEventsService eventsService, ILogger<EventsController> logger, IMapper mapper)
        {
            this.eventsService = eventsService;
            this.logger = logger;
            this.mapper = mapper;
        }

        [Authorize]
        public IActionResult All()
        {
            IEnumerable<Event> dbEvents = this.eventsService.GetAll();
            var eventViewModels = new List<EventAllViewModel>();

            foreach (Event item in dbEvents)
            {
                eventViewModels.Add(this.mapper.Map<EventAllViewModel>(item));
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
                    Tickets = item.Orders.Where(x => x.Customer.UserName == this.User.Identity.Name).Sum(x => x.TicketsCount)
                });
            }

            var viewModel = new MyEventsViewModel { Events = eventViewModels };

            return base.View(viewModel);
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
            Event @event = this.mapper.Map<Event>(model);

            this.eventsService.Create(@event);

            this.logger.LogInformation("Event created: " + @event.Name, @event);

            return base.RedirectToAction("All", "Events");
        }
    }
}