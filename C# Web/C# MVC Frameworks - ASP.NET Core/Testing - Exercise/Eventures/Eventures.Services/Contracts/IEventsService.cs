using Eventures.Models;
using Eventures.ViewModels.Events;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        IEnumerable<EventAllViewModel> GetAllWithRemainingTickets();

        IEnumerable<EventMyViewModel> GetAllForUser(string username);

        void Create(EventCreateViewModel model);

        Event GetLast();
    }
}
