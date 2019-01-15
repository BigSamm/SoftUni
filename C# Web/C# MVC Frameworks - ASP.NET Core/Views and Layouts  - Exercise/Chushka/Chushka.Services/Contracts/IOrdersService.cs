using Chushka.Models;
using System.Collections.Generic;

namespace Chushka.Services.Contracts
{
    public interface IOrdersService
    {
        List<Order> GetAll();

        void Register(int productId, string userId);
    }
}