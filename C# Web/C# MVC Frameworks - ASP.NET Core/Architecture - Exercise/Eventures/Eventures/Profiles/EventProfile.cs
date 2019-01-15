using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels.Events;

namespace Eventures.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            base.CreateMap<EventCreateViewModel, Event>();
            base.CreateMap<Event, EventAllViewModel>();
            base.CreateMap<Event, EventMyViewModel>();
        }
    }
}
