using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MinedraftTests
{
    public class ProviderControllerTests
    {
        private IEnergyRepository energyRepository;
        private IProviderController providerController;

        [SetUp]
        public void SetUp()
        {
            this.energyRepository = new EnergyRepository();
            this.providerController = new ProviderController(this.energyRepository);
        }

        [Test]
        public void ProvidersProduceEnergyAndStoresIt()
        {
            this.providerController.Register(new List<string> { "Solar", "1", "200" });

            for (int i = 0; i < 3; i++)
            {
                this.providerController.Produce();
            }

            Assert.That(this.providerController.TotalEnergyProduced, Is.EqualTo(600));
        }

        [Test]
        public void RemoveBrokenProvidersFromProviderController()
        {
            this.providerController.Register(new List<string> { "Pressure", "1", "100" });

            for (int i = 0; i < 8; i++)
            {
                this.providerController.Produce();
            }

            Assert.That(this.providerController.Entities.Count, Is.EqualTo(0));
        }

        [Test]
        public void RepairProvider()
        {
            this.providerController.Register(new List<string> { "Standart", "1", "100" });

            providerController.Repair(100);

            Assert.That(providerController.Entities.First().Durability, Is.EqualTo(1100));
        }
    }
}
