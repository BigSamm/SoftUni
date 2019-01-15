namespace IRunes.Models.Contracts
{
    using System.Collections.Generic;

    public interface ITrack : IModel
    {
        string Name { get; }

        string Link { get; }

        decimal Price { get; }
        
        string AlbumId { get; }
        Album Album { get; }
    }
}
