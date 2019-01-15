namespace Eventures.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Data;
    using Microsoft.AspNetCore.Hosting;
    using Models;

    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext dbContext;
        private readonly IHostingEnvironment hostingEnvironment;

        private Event lastCreatedEvent;

        public EventsService(EventuresDbContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            this.dbContext = dbContext;
            this.hostingEnvironment = hostingEnvironment;
        }

        public void Create(Event @event)
        {
            this.dbContext.Events.Add(@event);
            this.dbContext.SaveChanges();

            this.lastCreatedEvent = @event;
        }

        public List<Event> GetAll()
        {
            return this.dbContext.Events.Where(x => x.TotalTickets > 0).ToList();
        }

        public Event GetLast()
        {
            return this.lastCreatedEvent;
        }

        public IEnumerable<Event> GetAllByUsername(string username)
        {
            return this.dbContext.Events.Where(x => x.Orders.Any(y => y.Customer.UserName == username)).ToList();
        }        
    }
}
