namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Contracts;
    using Dtos;
    using Messages;
    using Services.Contracts;

    public class ModifyUserCommand : ICommand
    {
        private readonly IUserService userService;
        private readonly ITownService townService;

        public ModifyUserCommand(IUserService userService, ITownService townService)
        {
            this.userService = userService;
            this.townService = townService;
        }

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {
            string username = data[0];
            string property = data[1];
            string value = data[2];

            if (!this.userService.Exists(username))
                throw new ArgumentException(String.Format(ErrorMessages.UserNotFound, username));

            int userId = this.userService.ByUsername<UserDto>(username).Id;

            switch (property)
            {
                case "Password":
                    SetPassword(userId, value);
                    break;
                case "BornTown":
                    SetBornTown(userId, value);
                    break;
                case "CurrentTown":
                    SetCurrentTown(userId, value);
                    break;
                default:
                    throw new ArgumentException(String.Format(ErrorMessages.PropertyNotSupported, property));
            }

            string result = String.Format(ResultMessages.SuccessfullyModify, username, property, value);
            return result;
        }

        private void SetCurrentTown(int userId, string newTownName)
        {
            ValidateTownExists(newTownName);

            int newTownId = this.townService.ByName<TownDto>(newTownName).Id;

            this.userService.SetCurrentTown(userId, newTownId);
        }

        private void SetBornTown(int userId, string newTownName)
        {
            ValidateTownExists(newTownName);

            int newTownId = this.townService.ByName<TownDto>(newTownName).Id;

            this.userService.SetBornTown(userId, newTownId);
        }

        private void ValidateTownExists(string townName)
        {
            bool isTownExists = this.townService.Exists(townName);

            if (!isTownExists)
            {
                string exMessage = String.Format(ErrorMessages.ValueNotValid, townName) +
                    Environment.NewLine + String.Format(ErrorMessages.TownNotFound, townName);
                throw new ArgumentException(exMessage);
            }
        }

        private void SetPassword(int userId, string newPassword)
        {
            bool isValidPassword = newPassword.Any(x => Char.IsLower(x)) && newPassword.Any(x => Char.IsDigit(x));
            if (!isValidPassword)
            {
                string exMessage = String.Format(ErrorMessages.ValueNotValid, newPassword) +
                    Environment.NewLine + ErrorMessages.InvalidPassword;
                throw new ArgumentException(exMessage);
            }

            this.userService.ChangePassword(userId, newPassword);
        }
    }
}
