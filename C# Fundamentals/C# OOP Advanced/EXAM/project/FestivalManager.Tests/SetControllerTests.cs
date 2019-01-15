// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to your project (entities/controllers/etc)
namespace FestivalManager.Tests
{
    using FestivalManager.Core.Controllers;
    using FestivalManager.Core.Controllers.Contracts;
    using FestivalManager.Core.Repository;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using FestivalManager.Entities.Instruments;
    using FestivalManager.Entities.Sets;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Text;

    [TestFixture]
	public class SetControllerTests
    {
        private IStage stage;
        private ISetController setController;

        [SetUp]
        public void InitializeSetController()
        {
            this.stage = new Stage();
            this.setController = new SetController(this.stage);
        }

		[Test]
	    public void PerformSetsMethodReturnsExpectedResult()
        {
            this.stage.AddSet(new Medium("Set2"));
            this.stage.AddSet(new Medium("Set1"));
            this.stage.AddSet(new Long("Set3"));
            
            IPerformer performer1 = new Performer("per1", 1);
            IInstrument instrument1 = new Guitar();
            performer1.AddInstrument(instrument1);

            IPerformer performer2 = new Performer("per2", 1);
            IInstrument instrument2 = new Guitar();
            performer2.AddInstrument(instrument2);

            ISong song1 = new Song("Song1", new TimeSpan(0, 5, 0));
            ISong song2 = new Song("Song2", new TimeSpan(0, 6, 0));

            ISet set1 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set1");
            set1.AddSong(song1);
            set1.AddSong(song2);
            set1.AddPerformer(performer1);
            set1.AddPerformer(performer1);

            ISet set2 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set2");
            set2.AddSong(song1);
            set2.AddSong(song2);
            set2.AddPerformer(performer2);

            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("1. Set1:");
            expectedResult.AppendLine("-- 1. Song1 (05:00)");
            expectedResult.AppendLine("-- 2. Song2 (06:00)");
            expectedResult.AppendLine("-- Set Successful");
            expectedResult.AppendLine("2. Set2:");
            expectedResult.AppendLine("-- 1. Song1 (05:00)");
            expectedResult.AppendLine("-- 2. Song2 (06:00)");
            expectedResult.AppendLine("-- Set Successful");
            expectedResult.AppendLine("3. Set3:");
            expectedResult.Append("-- Did not perform");

            Assert.That(() => this.setController.PerformSets() , Is.EqualTo(expectedResult.ToString()));
        }

        [Test]
        public void OrderByActualDuration()
        {
            this.stage.AddSet(new Medium("Set1"));
            this.stage.AddSet(new Medium("Set2"));

            IPerformer performer1 = new Performer("per1", 1);
            IInstrument instrument1 = new Guitar();
            performer1.AddInstrument(instrument1);

            IPerformer performer2 = new Performer("per2", 1);
            IInstrument instrument2 = new Guitar();
            performer2.AddInstrument(instrument2);

            ISong song1 = new Song("Song1", new TimeSpan(0, 5, 0));
            ISong song2 = new Song("Song2", new TimeSpan(0, 6, 0));

            ISet set1 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set1");
            set1.AddPerformer(performer1);
            set1.AddSong(song1);

            ISet set2 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set2");
            set2.AddPerformer(performer2);
            set2.AddSong(song2);

            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("1. Set2:");
            expectedResult.AppendLine("-- 1. Song2 (06:00)");
            expectedResult.AppendLine("-- Set Successful");
            expectedResult.AppendLine("2. Set1:");
            expectedResult.AppendLine("-- 1. Song1 (05:00)");
            expectedResult.Append("-- Set Successful");

            Assert.That(() => this.setController.PerformSets(), Is.EqualTo(expectedResult.ToString()));
        }

        [Test]
        public void InstrumentBroke()
        {
            this.stage.AddSet(new Medium("Set1"));
            this.stage.AddSet(new Medium("Set2"));

            IPerformer performer1 = new Performer("per1", 1);
            IInstrument instrument1 = new Guitar();
            performer1.AddInstrument(instrument1);

            ISong song1 = new Song("Song1", new TimeSpan(0, 5, 0));

            ISet set1 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set1");
            set1.AddPerformer(performer1);
            set1.AddSong(song1);
            set1.AddSong(song1);

            ISet set2 = this.stage.Sets.FirstOrDefault(s => s.Name == "Set2");
            set2.AddPerformer(performer1);
            set2.AddSong(song1);

            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("1. Set1:");
            expectedResult.AppendLine("-- 1. Song1 (05:00)");
            expectedResult.AppendLine("-- 2. Song1 (05:00)");
            expectedResult.AppendLine("-- Set Successful");
            expectedResult.AppendLine("2. Set2:");
            expectedResult.Append("-- Did not perform");

            Assert.That(() => this.setController.PerformSets(), Is.EqualTo(expectedResult.ToString()));
        } 
    }
}