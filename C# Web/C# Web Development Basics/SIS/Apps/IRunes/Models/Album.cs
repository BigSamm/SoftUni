namespace IRunes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using Contracts;

    public class Album : IAlbum
    {
        public Album()
        {
            this.Tracks = new HashSet<Track>();
        }

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Cover { get; set; }

        public decimal? Price => this.Tracks.Sum(x => x.Price) * 0.87m;

        public virtual ICollection<Track> Tracks { get; set; }
    }
}