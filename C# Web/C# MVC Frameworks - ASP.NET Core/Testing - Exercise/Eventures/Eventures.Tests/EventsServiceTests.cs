using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Eventures.Profiles;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Eventures.Services.Tests
{
    public class EventsServiceTests
    {
        private readonly IServiceProvider provider;
        private readonly EventuresDbContext dbContext;
        private readonly IEventsService eventsService;

        public EventsServiceTests()
        {
            var services = new ServiceCollection();
            services.AddDbContext<EventuresDbContext>(opt =>
                opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            services.AddScoped<IEventsService, EventsService>();

            Mapper.Reset();
            Mapper.Initialize(config => config.AddProfile(typeof(EventuresProfile)));
            services.AddScoped<IMapper>(service => Mapper.Instance);

            this.provider = services.BuildServiceProvider();
            this.dbContext = provider.GetService<EventuresDbContext>();
            this.eventsService = provider.GetService<IEventsService>();
        }

        [Fact]
        public void Create_NewEventCreatedCorrectly()
        {
            var eventModel = new EventCreateViewModel
            { Name = "testName", Place = "testPlace", PricePerTicket = 100, TotalTickets = 1000 };
            this.eventsService.Create(eventModel);     
            Event dbEvent = this.dbContext.Events.First();

            dbEvent.ShouldSatisfyAllConditions
            (
                () => dbEvent.Name.ShouldBe("testName"),
                () => dbEvent.Place.ShouldBe("testPlace"),
                () => dbEvent.PricePerTicket.ShouldBe(100),
                () => dbEvent.TotalTickets.ShouldBe(1000)
            );
        }

        [Fact]
        public void Create_WithNullModel_ThrowArgumentNullException()
        {
            EventCreateViewModel eventModel = null;
            Action testCode = () => this.eventsService.Create(eventModel);
            testCode.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void Create_SetLastCreatedEventFieldCorectly()
        {
            var firstEvent = new EventCreateViewModel
            { Name = "firstEvent", Place = "firstEvent" };
            this.eventsService.Create(firstEvent);

            var lastEvent = new EventCreateViewModel
            { Name = "lastEvent", Place = "lastEvent" };
            this.eventsService.Create(lastEvent);

            FieldInfo fi = typeof(EventsService)
                .GetField("lastCreatedEvent", BindingFlags.NonPublic | BindingFlags.Instance);
            Event result = (Event)fi.GetValue(this.eventsService);

            result.ShouldSatisfyAllConditions
            (
                () => result.Name.ShouldBe("lastEvent"),
                () => result.Place.ShouldBe("lastEvent")
            );
        }

        [Fact]
        public void GetLast_ReturnsLastCreatedEvent()
        {
            var firstEvent = new EventCreateViewModel
            { Name = "firstEvent", Place = "firstEvent" };
            this.eventsService.Create(firstEvent);

            var lastEvent = new EventCreateViewModel
            { Name = "lastEvent", Place = "lastEvent" };
            this.eventsService.Create(lastEvent);

            Event result = this.eventsService.GetLast();

            result.ShouldSatisfyAllConditions
            (
                () => result.Name.ShouldBe("lastEvent"),
                () => result.Place.ShouldBe("lastEvent")
            );
        }

        [Fact]
        public void GetAllWithRemainingTickets_ReturnsOnlyEventsWithRemainingTickets()
        {
            var firstEvent = new Event
            { Name = "firstEvent", TotalTickets = 0 };
            this.dbContext.Events.Add(firstEvent);

            var secondEvent = new Event
            { Name = "secondEvent", TotalTickets = 1 };
            this.dbContext.Events.Add(secondEvent);
            dbContext.SaveChanges();

            var result = this.eventsService.GetAllWithRemainingTickets();

            result.Count().ShouldBe(1);
            result.First().Name.ShouldBe("secondEvent");
        }

        [Fact]
        public void GetAllWithRemainingTickets_DbContextWithoutEvents_ReturnsEmptyCollection()
        {
            var result = this.eventsService.GetAllWithRemainingTickets();
            result.Count().ShouldBe(0);
        }

        [Fact]
        public void GetAllForUser_ReturnsEventsForGivenUser()
        {
            string testUsername = "needed";
            var firstEvent = new Event
            {
                Name = "firstEvent",
                Orders = new List<Order>()
                { new Order { Customer = new EventuresUser { UserName = testUsername } } }
            };
            this.dbContext.Events.Add(firstEvent);

            var secondEvent = new Event
            {
                Name = "secondEvent",
                Orders = new List<Order>()
                { new Order { Customer = new EventuresUser { UserName = "test" } } }
            };
            this.dbContext.Events.Add(secondEvent);
            dbContext.SaveChanges();

            var result = this.eventsService.GetAllForUser(testUsername);

            result.Count().ShouldBe(1);
            result.First().Name.ShouldBe("firstEvent");
        }

        [Fact]
        public void GetAllForUser_DbContextWithoutEvents_ReturnsEmptyCollection()
        {
            var result = this.eventsService.GetAllForUser("testUsername");
            result.Count().ShouldBe(0);

        }

        [Fact]
        public void GetAllForUser_ReturnsCorrectTicketsCountForGiverUser()
        {
            string testUsername = "testUsername";
            var firstEvent = new Event
            {
                Name = "firstEvent",
                Orders = new List<Order>()
                {
                    new Order
                    {
                        Customer = new EventuresUser { UserName = testUsername },
                        TicketsCount = 1
                    }
                }
            };
            this.dbContext.Events.Add(firstEvent);
            this.dbContext.SaveChanges();

            var result = this.eventsService.GetAllForUser(testUsername).First();

            result.Tickets.ShouldBe(1);
        }
    }
}
