using Eventures.Data;
using Eventures.Models;
using Eventures.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eventures.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly EventuresDbContext dbContext;

        public OrdersService(EventuresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(string userId, string eventId, int tickets)
        {
            var order = new Order
            {
                CustomerId = userId,
                EventId = eventId,
                TicketsCount = tickets,
                OrderedOn = DateTime.UtcNow,
            };

            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return this.dbContext.Orders.ToList();
        }
    }
}
