using System.Collections.Generic;
using System.Linq;
using Chushka.App.Services.Contracts;
using Chushka.Data;
using Chushka.Models;

namespace Chushka.App.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ChushkaDbContext dbContext;

        public OrdersService(ChushkaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return this.dbContext.Orders.ToList();
        }

        public void Register(int productId, int userId)
        {
            var order = new Order
            {
                ClientId = userId,
                ProductId = productId,
            };

            this.dbContext.Orders.Add(order);
            this.dbContext.SaveChanges();
        }
    }
}
