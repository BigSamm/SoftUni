using Eventures.Models;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

namespace Eventures.Filters
{
    public class AdminCreateEventActionFilter : IActionFilter
    {
        private readonly ILogger<AdminCreateEventActionFilter> logger;
        private readonly IEventsService eventsService;

        public AdminCreateEventActionFilter(ILogger<AdminCreateEventActionFilter> logger, IEventsService eventsService)
        {
            this.logger = logger;
            this.eventsService = eventsService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            string username = context.HttpContext.User.Identity.Name;
            Event @event = this.eventsService.GetLast();

            this.logger.LogInformation(
                $"[{DateTime.UtcNow}] Administrator {username} create event {@event.Name} ({@event.Start} / {@event.End}).");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        { }
    }
}
