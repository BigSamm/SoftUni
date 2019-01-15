using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IOrdersService
    {
        void Create(string userId, string eventId, int tickets);

        IEnumerable<Order> GetAll();
    }
}
