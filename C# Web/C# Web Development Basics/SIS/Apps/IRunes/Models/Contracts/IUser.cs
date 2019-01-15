namespace IRunes.Models.Contracts
{
    public interface IUser : IModel
    {
        string Username { get; }

        string Password { get; }

        string Email { get; }
    }
}
