using AutoMapper;
using Eventures.Models;
using Eventures.ViewModels.Users;

namespace Eventures.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            base.CreateMap<UserRegisterViewModel, EventuresUser>();
        }
    }
}
