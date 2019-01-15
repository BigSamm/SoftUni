namespace MappingObjects.App.Core.Commands
{
    using Contracts;

    public class ExitCommand : IExecutable
    {
        public string Execute(string[] args)
        {
            string result = "Exit";
            return result;
        }
    }
}
