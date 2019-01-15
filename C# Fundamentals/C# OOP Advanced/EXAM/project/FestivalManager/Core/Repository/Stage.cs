namespace FestivalManager.Core.Repository
{
	using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using FestivalManager.Entities.Contracts;

    public class Stage : IStage
	{
        private readonly List<ISet> sets = new List<ISet>();
        private readonly List<ISong> songs = new List<ISong>();
        private readonly List<IPerformer> performers = new List<IPerformer>();

        public IReadOnlyCollection<ISet> Sets => this.sets.AsReadOnly();

        public IReadOnlyCollection<ISong> Songs => this.songs.AsReadOnly();

        public IReadOnlyCollection<IPerformer> Performers => this.performers.AsReadOnly();

        public void AddPerformer(IPerformer performer)
        {
            this.performers.Add(performer);
        }

        public void AddSet(ISet set)
        {
            this.sets.Add(set);
        }

        public void AddSong(ISong song)
        {
            this.songs.Add(song);
        }

        public IPerformer GetPerformer(string name)
        {
            IPerformer performer = this.performers.Find(p => p.Name == name);
            return performer;
        }

        public ISet GetSet(string name)
        {
            ISet set = this.sets.Find(s => s.Name == name);
            return set;
        }

        public ISong GetSong(string name)
        {
            ISong song = this.songs.Find(s => s.Name == name);
            return song;
        }

        public bool HasPerformer(string name)
        {
            bool result = this.performers.Any(p => p.Name == name);
            return result;
        }

        public bool HasSet(string name)
        {
            bool result = this.sets.Any(s => s.Name == name);
            return result;
        }

        public bool HasSong(string name)
        {
            bool result = this.songs.Any(s => s.Name == name);
            return result;
        }
    }
}
