using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IOrdersService
    {
        bool Create(string userId, string eventId, int tickets);

        IEnumerable<Order> GetAll();
    }
}
