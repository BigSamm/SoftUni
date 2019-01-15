using Chushka.Models;
using System.Collections.Generic;

namespace Chushka.App.Services.Contracts
{
    public interface IOrdersService
    {
        List<Order> GetAll();

        void Register(int productId, int userId);
    }
}