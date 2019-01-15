using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Eventures.Profiles;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace Eventures.Services.Tests
{
    public class OrdersServiceTests
    {
        private readonly IServiceProvider provider;
        private readonly EventuresDbContext dbContext;
        private readonly IOrdersService ordersService;

        public OrdersServiceTests()
        {
            var services = new ServiceCollection();
            services.AddDbContext<EventuresDbContext>(opt =>
                opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<UserManager<EventuresUser>>();
            services.AddScoped<UserStore<EventuresUser>>();
            
            services.AddIdentity<EventuresUser, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<EventuresDbContext>();

            Mapper.Reset();
            Mapper.Initialize(config => config.AddProfile(typeof(EventuresProfile)));
            services.AddScoped<IMapper>(service => Mapper.Instance);

            this.provider = services.BuildServiceProvider();
            this.dbContext = provider.GetService<EventuresDbContext>();
            this.ordersService = provider.GetService<IOrdersService>();
        }

        [Fact]
        public void Create_NewEventCreatedCorrectlyAndReturnTrue()
        {
            string username = "test";
            this.dbContext.Users.Add(new EventuresUser { UserName = username });
            string eventId = "test";
            this.dbContext.Events.Add(new Event { Id = eventId, TotalTickets = 1 });
            this.dbContext.SaveChanges();

            int tickets = 1;
            this.ordersService.Create(eventId, tickets, username).ShouldBeTrue();
            Order dbOrder = this.dbContext.Orders.First();

            dbOrder.ShouldSatisfyAllConditions
            (
                () => dbOrder.Customer.UserName.ShouldBe(username),
                () => dbOrder.EventId.ShouldBe(eventId),
                () => dbOrder.TicketsCount.ShouldBe(1)
            );
        }

        [Fact]
        public void Create_WithNullUsername_ThorwsArgumentNullException()
        {
            string username = null;
            string eventId = "test";
            int tickets = 1;
            
            Action testCode = () => this.ordersService.Create(eventId, tickets, username);
            testCode.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void Create_WithNullEventId_ThorwsArgumentNullException()
        {
            string username = "test";
            string eventId = null;
            int tickets = 1;

            Action testCode = () => this.ordersService.Create(eventId, tickets, username);
            testCode.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void Create_WithEventTicketsCountSmallerThanOrderTicketsCount_FailCreateAndReturnFalse()
        {
            string username = "test";
            this.dbContext.Users.Add(new EventuresUser { UserName = username });
            string eventId = "test";
            this.dbContext.Events.Add(new Event { Id = eventId, TotalTickets = 1 });
            this.dbContext.SaveChanges();

            int tickets = 2;

            this.ordersService.Create(eventId, tickets, username).ShouldBeFalse();
            this.dbContext.Orders.Count().ShouldBe(0);
        }

        [Fact]
        public void Create_DecreaseGivenEventTicketsCount()
        {
            string username = "test";
            this.dbContext.Users.Add(new EventuresUser { UserName = username });
            string eventId = "test";
            this.dbContext.Events.Add(new Event { Id = eventId, TotalTickets = 3 });
            this.dbContext.SaveChanges();

            int tickets = 1;
            this.ordersService.Create(eventId, tickets, username);

            var result = this.dbContext.Events.First();
            result.TotalTickets.ShouldBe(2);
        }

        [Fact]
        public void GetAll_ReturnAllOrders()
        {
            var firstOrder = new Order();
            this.dbContext.Orders.Add(firstOrder);
            var secondOrder = new Order();
            this.dbContext.Orders.Add(secondOrder);
            this.dbContext.SaveChanges();

            var result = this.ordersService.GetAll().Count();
            result.ShouldBe(2);
        }
    }
}
