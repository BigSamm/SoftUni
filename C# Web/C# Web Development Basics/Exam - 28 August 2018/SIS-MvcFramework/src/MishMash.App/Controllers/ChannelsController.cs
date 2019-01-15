using MishMash.App.Models;
using MishMash.App.Models.Enums;
using MishMash.App.ViewModels.Channels;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System;
using System.Linq;

namespace MishMash.App.Controllers
{
    public class ChannelsController : BaseController
    {
        [Authorize]
        public IHttpResponse Followed()
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var followedChannels = base.DbContext.Channels
                .Where(x => x.Followers.Any(f => f.User.Username == this.User.Username))
                .Select(x => new BaseChannelViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type,
                    FollowersCount = x.Followers.Count
                });

            var viewModel = new FollowedChannelsViewModel { FollowedChannels = followedChannels };

            return base.View(viewModel);
        }
        
        [Authorize]
        public IHttpResponse Details(int id)
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var channelViewModel = base.DbContext.Channels.Where(x => x.Id == id)
                .Select(x => new ChannelViewModel
                {
                    Name = x.Name,
                    Description = x.Description,
                    Type = x.Type,
                    Tags = x.Tags.Select(t => t.Tag.Name),
                    FollowersCount = x.Followers.Count
                }).FirstOrDefault();

            if (channelViewModel == null)
                return base.BadRequestError("Invalid channel.");

            return base.View(channelViewModel);
        }

        [Authorize]
        public IHttpResponse Unfollow(int id)
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var userChannel = base.DbContext.UsersChannels
                .FirstOrDefault(x => x.User.Username == this.User.Username && x.ChannelId == id);

            if (userChannel == null)
                return base.BadRequestError("Invalid channel.");

            base.DbContext.UsersChannels.Remove(userChannel);
            base.DbContext.SaveChanges();

            return base.Redirect("/Channels/Followed");
        }

        [Authorize]
        public IHttpResponse Follow(int id)
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var user = base.DbContext.Users.FirstOrDefault(x => x.Username == this.User.Username);

            if (base.DbContext.UsersChannels.Any(x => x.UserId == user.Id && x.ChannelId == id))
                return Redirect("/Channels/Followed");

            var userChannel = new UserChannel
            {
                UserId = user.Id,
                ChannelId = id
            };

            base.DbContext.UsersChannels.Add(userChannel);
            base.DbContext.SaveChanges();

            return base.Redirect("/Channels/Followed");
        }

        [Authorize]
        public IHttpResponse Create()
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var user = base.DbContext.Users.FirstOrDefault(x => x.Username == this.User.Username);
            if (user.Role != UserRole.Admin)
                return base.Redirect("/");

            return base.View();
        }

        [HttpPost]
        [Authorize]
        public IHttpResponse Create(CreateChannelsViewModel model)
        {
            if (!base.Request.Cookies.ContainsCookie(".auth-cakes"))
                return base.Redirect("/Users/Login");

            var user = base.DbContext.Users.FirstOrDefault(x => x.Username == this.User.Username);
            if (user.Role != UserRole.Admin)
                return base.Redirect("/");

            bool isValidType = Enum.TryParse(model.Type, true, out ChannelType type);
            if (!isValidType)
                return base.BadRequestErrorWithView("Invalid channel type.");

            var channel = new Channel
            {
                Description = model.Description,
                Name = model.Name,
                Type = type
            };

            if (!string.IsNullOrWhiteSpace(model.Tags))
            {
                string[] tags = model.Tags.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string tag in tags)
                {
                    Tag dbTag = base.DbContext.Tags.FirstOrDefault(x => x.Name == tag.Trim());

                    if (dbTag == null)
                    {
                        dbTag = new Tag { Name = tag.Trim() };
                        base.DbContext.Tags.Add(dbTag);
                        base.DbContext.SaveChanges();
                    }

                    channel.Tags.Add(new ChannelTag { Tag = dbTag });
                }
            }

            base.DbContext.Channels.Add(channel);
            base.DbContext.SaveChanges();

            return base.Redirect("/Channels/Details?id=" + channel.Id);
        }
    }
}