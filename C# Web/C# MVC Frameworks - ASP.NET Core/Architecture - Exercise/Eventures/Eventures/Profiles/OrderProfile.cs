using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels.Orders;

namespace Eventures.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            base.CreateMap<Order, OrderAllViewModel>();
        }
    }
}
