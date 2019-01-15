using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels.Events;
using Eventures.ViewModels.Orders;
using Eventures.ViewModels.Users;

namespace Eventures.Profiles
{
    public class EventuresProfile : Profile
    {
        public EventuresProfile()
        {
            base.CreateMap<EventCreateViewModel, Event>();
            base.CreateMap<Event, EventAllViewModel>();
            base.CreateMap<Event, EventMyViewModel>();

            base.CreateMap<Order, OrderAllViewModel>();

            base.CreateMap<UserRegisterViewModel, EventuresUser>();
        }
    }
}
