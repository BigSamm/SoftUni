using AutoMapper;
using Eventures.Filters;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReflectionIT.Mvc.Paging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult All(int page = 1)
        {
            IEnumerable<Event> dbEvents = this.eventsService.GetAll();

            IEnumerable<EventAllViewModel> events = dbEvents
                .Select(item => this.mapper.Map<EventAllViewModel>(item))
                .AsQueryable()
                .OrderBy(x => x.Id);
            
            IPagingList<EventAllViewModel> viewModel = PagingList.Create(events, 6, page);
            return View(viewModel);
        }

        [Authorize]
        public IActionResult My(int page = 1)
        {
            IEnumerable<Event> dbEvents = this.eventsService.GetAllByUsername(this.User.Identity.Name);
            var events = new List<EventMyViewModel>();

            foreach (Event item in dbEvents)
            {
                var eventModel = this.mapper.Map<EventMyViewModel>(item);
                eventModel.Tickets = item.Orders.Where(x => x.Customer.UserName == this.User.Identity.Name).Sum(x => x.TicketsCount);
                events.Add(eventModel);
            }
            
            var qry = events.AsQueryable().OrderBy(x => x.Id);
            IPagingList<EventMyViewModel> viewModel = PagingList.Create(qry, 8, page);
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
            Event @event = this.mapper.Map<Event>(model);

            this.eventsService.Create(@event);

            this.logger.LogInformation("Event created: " + @event.Name, @event);

            return base.RedirectToAction("All", "Events");
        }
    }
}