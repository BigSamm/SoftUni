namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Text;

    using Contracts;
    using Dtos;
    using Messages;
    using Services.Contracts;

    public class PrintFriendsListCommand : ICommand
    {
        private readonly IUserService userService;

        public PrintFriendsListCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // ListFriends <username>
        public string Execute(string[] data)
        {
            string username = data[0];

            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));

            UserFriendsDto user = this.userService.ByUsername<UserFriendsDto>(username);

            if (user.Friends.Count == 0)
                return ResultMessages.UserHaveNoFriends;

            var result = new StringBuilder();
            result.AppendLine(ResultMessages.Friends);

            foreach (FriendDto friend in user.Friends)
            {
                result.AppendLine(String.Format(ResultMessages.Friend, friend.Username));
            }

            return result.ToString().Trim();
        }
    }
}
