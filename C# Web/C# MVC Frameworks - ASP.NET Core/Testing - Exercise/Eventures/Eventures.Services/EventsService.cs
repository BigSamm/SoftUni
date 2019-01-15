namespace Eventures.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Contracts;
    using Data;
    using Eventures.ViewModels.Events;
    using Models;

    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext dbContext;
        private readonly IMapper mapper;

        private Event lastCreatedEvent;

        public EventsService(EventuresDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public void Create(EventCreateViewModel model)
        {
            Event @event = this.mapper.Map<Event>(model);
            
            this.dbContext.Events.Add(@event);
            this.dbContext.SaveChanges();

            this.lastCreatedEvent = @event;
        }

        public Event GetLast()
        {
            return this.lastCreatedEvent;
        }

        public IEnumerable<EventAllViewModel> GetAllWithRemainingTickets()
        {
            IEnumerable<Event> dbEvents = this.dbContext.Events
                .Where(x => x.TotalTickets > 0).ToList();

            IEnumerable<EventAllViewModel> events = dbEvents
                .Select(item => this.mapper.Map<EventAllViewModel>(item));

            return events;
        }

        public IEnumerable<EventMyViewModel> GetAllForUser(string username)
        {
            IEnumerable<Event> dbEvents = this.dbContext.Events
                .Where(x => x.Orders.Any(y => y.Customer.UserName == username))
                .ToList();

            var events = new List<EventMyViewModel>();

            foreach (Event item in dbEvents)
            {
                var eventModel = this.mapper.Map<EventMyViewModel>(item);
                eventModel.Tickets = item.Orders
                    .Where(x => x.Customer.UserName == username)
                    .Sum(x => x.TicketsCount);
                events.Add(eventModel);
            }

            return events;
        }        
    }
}
