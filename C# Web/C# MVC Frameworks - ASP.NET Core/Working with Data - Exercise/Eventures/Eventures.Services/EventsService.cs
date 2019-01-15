namespace Eventures.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Data;
    using Models;

    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext dbContext;
        private Event lastCreatedEvent;

        public EventsService(EventuresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Event @event)
        {
            this.dbContext.Events.Add(@event);
            this.dbContext.SaveChanges();

            this.lastCreatedEvent = @event;
        }

        public IEnumerable<Event> GetAll()
        {
            return this.dbContext.Events.ToList();
        }

        public Event GetLast()
        {
            return this.lastCreatedEvent;
        }
    }
}
