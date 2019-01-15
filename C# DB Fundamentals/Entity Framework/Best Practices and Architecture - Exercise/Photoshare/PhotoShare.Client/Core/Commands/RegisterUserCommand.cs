namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Contracts;
    using Dtos;
    using Messages;
    using Services.Contracts;

    public class RegisterUserCommand : ICommand
    {
        private readonly IUserService userService;

        public RegisterUserCommand(IUserService userService)
        {
            this.userService = userService;
        }
        
        // RegisterUser <username> <password> <repeat-password> <email>
        public string Execute(string[] data)
        {
            string username = data[0];
            string password = data[1];
            string repeatPassword = data[2];
            string email = data[3];
            
            var registerUserDto = new RegisterUserDto
            {
                Username = username,
                Password = password,
                Email = email
            };

            if (!this.IsValid(registerUserDto))
                throw new ArgumentException(ErrorMessages.InvalidData);

            if (this.userService.Exists(username))
                throw new InvalidOperationException(String.Format(ErrorMessages.UsernameIsTaken, username));

            if (password != repeatPassword)
                throw new ArgumentException(ErrorMessages.PasswordsDoNotMatch);

            this.userService.Register(username, password, email);

            string result = String.Format(ResultMessages.SuccessfullyRegisteredUser, username);
            return result;
        }

        private bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}
