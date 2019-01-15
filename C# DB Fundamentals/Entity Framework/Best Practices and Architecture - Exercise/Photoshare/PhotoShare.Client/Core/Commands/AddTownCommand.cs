namespace PhotoShare.Client.Core.Commands
{
    using System;
    
    using Contracts;
    using Messages;
    using Services.Contracts;

    public class AddTownCommand : ICommand
    {
        private readonly ITownService townService;

        public AddTownCommand(ITownService townService)
        {
            this.townService = townService;
        }

        // AddTown <townName> <countryName>
        public string Execute(string[] data)
        {
            string townName = data[0];
            string country = data[1];

            if (this.townService.Exists(townName))
                throw new ArgumentException(String.Format(ErrorMessages.TownAlreadyAdded, townName));

            this.townService.Add(townName, country);

            string result = String.Format(ResultMessages.SuccessfullyAddedTown, townName);
            return result;
        }
    }
}
