using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IUnitFactory unitFactory;
        [Inject]
        private IRepository repository;

        public AddCommand(string[] data, IUnitFactory unitFactory, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }
        
        protected IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            private set { unitFactory = value; }
        }

        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
           this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
