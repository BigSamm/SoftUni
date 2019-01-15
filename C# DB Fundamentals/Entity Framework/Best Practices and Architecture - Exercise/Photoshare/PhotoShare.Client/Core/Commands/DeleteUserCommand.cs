namespace PhotoShare.Client.Core.Commands
{
    using System;
    
    using Contracts;
    using Messages;
    using Services.Contracts;

    public class DeleteUserCommand : ICommand
    {
        private readonly IUserService userService;

        public DeleteUserCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // DeleteUser <username>
        public string Execute(string[] data)
        {
            string username = data[0];

            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));

            this.userService.Delete(username);

            string result = String.Format(ResultMessages.SuccessfullyDeletedUser, username);
            return result;
        }
    }
}
