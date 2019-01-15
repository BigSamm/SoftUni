using System;
using NUnit.Framework;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            var axe = this.InitializeAxe(5, 10);
            var dummy = this.InitializeDummy(10, 10);

            axe.Attack(dummy);

            Assert.True(dummy.Health.Equals(5));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            var axe = this.InitializeAxe(5, 10);
            var dummy = this.InitializeDummy(0, 10);

            Assert.That(() => axe.Attack(dummy),
                Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            var dummy = this.InitializeDummy(0, 10);

            var givenExperienceReturn = dummy.GiveExperience();

            Assert.True(givenExperienceReturn.Equals(10));
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            var dummy = this.InitializeDummy(10, 10);

            Assert.That(() => dummy.GiveExperience(),
                Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
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
