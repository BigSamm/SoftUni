using Eventures.Models;
using System.Collections.Generic;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        IEnumerable<Event> GetAll();

        void Create(Event @event);

        Event GetLast();
    }
}
