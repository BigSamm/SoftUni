namespace MappingObjects.App.Core.Commands
{
    using System;

    using Contracts;
    using Dtos;

    public class SetBirthdayCommand : IExecutable
    {
        private readonly IEmployeeController employeeController;

        public SetBirthdayCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            DateTime date = DateTime.ParseExact(args[1], "dd-MM-yyyy", null);

            this.employeeController.SetBirthday(employeeId, date);

            string result = $"Birthday was set successfully on employee with Id {employeeId}.";
            return result;
        }
    }
}
