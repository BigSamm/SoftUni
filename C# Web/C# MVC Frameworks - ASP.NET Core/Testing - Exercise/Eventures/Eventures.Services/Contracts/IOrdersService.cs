using Eventures.ViewModels.Orders;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IOrdersService
    {
        bool Create(string eventId, int tickets, string username);

        IEnumerable<OrderAllViewModel> GetAll();
    }
}
