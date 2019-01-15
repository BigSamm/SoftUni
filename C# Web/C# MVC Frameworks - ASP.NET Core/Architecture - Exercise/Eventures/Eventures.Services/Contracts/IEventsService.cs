using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        List<Event> GetAll();

        IEnumerable<Event> GetAllByUsername(string username);

        void Create(Event @event);

        Event GetLast();
    }
}
