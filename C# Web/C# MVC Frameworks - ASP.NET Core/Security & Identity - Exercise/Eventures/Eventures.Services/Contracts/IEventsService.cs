using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        IEnumerable<Event> GetAll();

        IEnumerable<Event> GetAllByUsername(string username);

        void Create(Event @event);

        Event GetLast();
    }
}
