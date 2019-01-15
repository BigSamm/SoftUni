namespace IRunes.Models.Contracts
{
    using System.Collections.Generic;

    public interface IAlbum : IModel
    {
        string Name { get; }

        string Cover { get; }

        decimal? Price { get; }

        ICollection<Track> Tracks { get; }
    }
}
