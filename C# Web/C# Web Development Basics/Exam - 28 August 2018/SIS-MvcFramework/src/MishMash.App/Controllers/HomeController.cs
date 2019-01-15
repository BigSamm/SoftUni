using MishMash.App.ViewModels.Channels;
using MishMash.App.ViewModels.Home;
using SIS.HTTP.Responses;
using System.Linq;

namespace MishMash.App.Controllers
{
    public class HomeController : BaseController
    {
        public IHttpResponse Index()
        {
            if (this.User.IsLoggedIn)
            {
                var viewModel = new LoggedInIndexViewModel();
                viewModel.YourChannels = base.DbContext.Channels
                    .Where(x => x.Followers.Any(f => f.User.Username == this.User.Username))
                    .Select(x => new BaseChannelViewModel
                    {
                        Id = x.Id,
                        Type = x.Type,
                        Name = x.Name,
                        FollowersCount = x.Followers.Count(),
                    }).ToList();

                var followedChannelsTags = base.DbContext.Channels
                    .Where(x => x.Followers.Any(f => f.User.Username == this.User.Username))
                    .SelectMany(x => x.Tags.Select(t => t.TagId)).ToList();

                viewModel.SuggestedChannels = base.DbContext.Channels
                    .Where(x => !x.Followers.Any(f => f.User.Username == this.User.Username)
                           && x.Tags.Any(t => followedChannelsTags.Contains(t.TagId)))
                    .Select(x => new BaseChannelViewModel
                    {
                        Id = x.Id,
                        Type = x.Type,
                        Name = x.Name,
                        FollowersCount = x.Followers.Count(),
                    }).ToList();

                var ids = viewModel.YourChannels.Select(x => x.Id).ToList();
                ids = ids.Concat(viewModel.SuggestedChannels.Select(x => x.Id)).ToList();
                ids = ids.Distinct().ToList();

                viewModel.SeeOtherChannels = base.DbContext.Channels.Where(x => !ids.Contains(x.Id))
                    .Select(x => new BaseChannelViewModel
                    {
                        Id = x.Id,
                        Type = x.Type,
                        Name = x.Name,
                        FollowersCount = x.Followers.Count(),
                    }).ToList();

                return this.View("Home/LoggedInIndex", viewModel);
            }
            else
            {
                return base.View();
            }
        }
    }
}