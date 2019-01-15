namespace IRunes.Services.Contracts
{
    public interface IUsersService
    {
        bool ExistsByUsernameAndPassword(string username, string password);

        bool ExistsByEmail(string emial);

        bool AreSamePasswords(string password, string confirmPassword);
        
        bool TryAddToDatabase(string username, string password, string email);
    }
}