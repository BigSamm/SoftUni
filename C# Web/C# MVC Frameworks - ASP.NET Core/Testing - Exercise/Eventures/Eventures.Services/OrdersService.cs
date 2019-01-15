using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.ViewModels.Orders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly EventuresDbContext dbContext;
        private readonly IMapper mapper;
        private readonly UserManager<EventuresUser> userManager;

        public OrdersService(EventuresDbContext dbContext, IMapper mapper, UserManager<EventuresUser> userManager)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public bool Create(string eventId, int tickets, string username)
        {
            EventuresUser currentUser = this.userManager.Users
                .FirstOrDefault(x => x.UserName == username);
            Event @event = this.dbContext.Events.FirstOrDefault(x => x.Id == eventId);

            if (currentUser == null || @event == null)
                throw new ArgumentNullException();

            if (@event.TotalTickets < tickets)
                return false;

            var order = new Order
            {
                CustomerId = currentUser.Id,
                EventId = eventId,
                TicketsCount = tickets,
                OrderedOn = DateTime.UtcNow,
            };

            @event.TotalTickets -= tickets;

            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();

            return true;
        }

        public IEnumerable<OrderAllViewModel> GetAll()
        {
            IEnumerable<Order> dbOrders = this.dbContext.Orders.ToList();
            IEnumerable<OrderAllViewModel> orders = dbOrders.Select(order => this.mapper.Map<OrderAllViewModel>(order));
            return orders;
        }
    }
}
