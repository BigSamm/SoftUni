namespace IRunes.Services.Contracts
{
    public interface IAlbumsService
    {
        bool TryAddToDatabase(string name, string cover);
    }
}