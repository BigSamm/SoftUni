using NUnit.Framework;
using System;

namespace Tests
{
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            var axe = this.InitializeAxe(10, 10);
            var dummy = this.InitializeDummy(10, 10);

            axe.Attack(dummy);

            Assert.True(axe.DurabilityPoints.Equals(9), "Axe Durability doesn't change after attack.");
        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            var axe = this.InitializeAxe(10, 0);
            var dummy = this.InitializeDummy(10, 10);

            Assert.That(() => axe.Attack(dummy), 
                Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }

        private Axe InitializeAxe(int axeAttack, int axeDurability)
        {
            var axe = new Axe(axeAttack, axeDurability);
            return axe;
        }

        private Dummy InitializeDummy(int dummyHealth, int dummyExperience)
        {
            var dummy = new Dummy(dummyHealth, dummyExperience);
            return dummy;
        }
    }
}
