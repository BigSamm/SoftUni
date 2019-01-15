using AutoMapper;
using Eventures.Filters;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;
using System.Collections.Generic;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;
        private readonly IMapper mapper;

        public EventsController(IEventsService eventsService, IMapper mapper)
        {
            this.eventsService = eventsService;
            this.mapper = mapper;
        }

        [Authorize]
        public IActionResult All(int page = 1)
        {
            IEnumerable<EventAllViewModel> events = this.eventsService.GetAllWithRemainingTickets();
            IPagingList<EventAllViewModel> viewModel = PagingList.Create(events, 6, page);
            return View(viewModel);
        }

        [Authorize]
        public IActionResult My(int page = 1)
        {
            IEnumerable<EventMyViewModel> events = this.eventsService.GetAllForUser(this.User.Identity.Name);
            IPagingList<EventMyViewModel> viewModel = PagingList.Create(events, 8, page);
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
            if (!ModelState.IsValid)
                return base.View(model);

            this.eventsService.Create(model);
            return base.RedirectToAction("All", "Events");
        }
    }
}