namespace IRunes.Models.Contracts
{
    public interface ITrackAlbum
    {
        string TrackId { get; }
        Track Track { get; }
        
        string AlbumId { get; }
        Album Album { get; }
    }
}
