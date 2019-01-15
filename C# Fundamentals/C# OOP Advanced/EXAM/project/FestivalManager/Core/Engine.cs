namespace FestivalManager.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
    using FestivalManager.Core.IO;
    using IO.Contracts;
    
	class Engine : IEngine
	{
        private IReader reader = new ConsoleReader();
        private IWriter writer = new ConsoleWriter();

        private IFestivalController festivalCоntroller;
        private ISetController setCоntroller;

        public Engine(IFestivalController festivalController, ISetController setController)
        {
            this.festivalCоntroller = festivalController;
            this.setCоntroller = setController;
        }
        
        public void Run()
		{
			while (true)
			{
				string input = reader.ReadLine();

				if (input == "END")
					break;

				try
				{
					string.Intern(input);

					string result = this.ProcessCommand(input);
					this.writer.WriteLine(result);
				}
				catch (Exception ex)
				{
					this.writer.WriteLine("ERROR: " + ex.Message);
				}
			}

            string end = this.festivalCоntroller.ProduceReport();

			this.writer.WriteLine("Results:");
			this.writer.WriteLine(end);
		}

		public string ProcessCommand(string input)
		{
			string[] tokens = input.Split();

			var command = tokens[0];
			var @params = tokens.Skip(1).ToArray();

			if (command == "LetsRock")
			{
				string sets = this.setCоntroller.PerformSets();
				return sets;
			}

			var festivalControlFunction = this.festivalCоntroller.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == command);

			string result;

			try
			{
				result = (string)festivalControlFunction.Invoke(this.festivalCоntroller, new object[] { @params });
			}
			catch (TargetInvocationException up)
			{
				throw up.InnerException;
			}

			return result;
		}
    }
}