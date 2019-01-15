using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels.Events;
using System.Linq;

namespace Eventures.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            base.CreateMap<Event, EventAllViewModel>();
            base.CreateMap<EventCreateViewModel, Event>();

        }
    }
}
