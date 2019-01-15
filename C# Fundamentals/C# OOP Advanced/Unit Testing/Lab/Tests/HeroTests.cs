using Moq;
using NUnit.Framework;

public class HeroTests
{
    private const string HERO_NAME = "Pesho";

    [Test]
    public void HeroGainsExperienceAfterAttackIfTargetDies()
    {
        var fakeTarget = new Mock<ITarget>();
        fakeTarget.Setup(p => p.Health).Returns(0);
        fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
        fakeTarget.Setup(p => p.IsDead()).Returns(true);

        var fakeWeapon = new Mock<IWeapon>();

        var hero = new Hero(HERO_NAME, fakeWeapon.Object);
        hero.Attack(fakeTarget.Object);

        Assert.That(hero.Experience, Is.EqualTo(20));
    }
}