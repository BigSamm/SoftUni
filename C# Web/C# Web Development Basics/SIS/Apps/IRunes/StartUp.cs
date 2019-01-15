namespace IRunes
{
    using Services.Contracts;
    using Services;
    using SIS.Framework.Api;
    using SIS.Framework.Services.Contracts;
    using global::Services.Contracts;
    using global::Services;

    public class StartUp : MvcApplication
    {
        public override void ConfigureServices(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterDependency<IHashService, HashService>();
            dependencyContainer.RegisterDependency<IUsersService, UsersService>();
            dependencyContainer.RegisterDependency<IAlbumsService, AlbumsService>();
            dependencyContainer.RegisterDependency<ITracksService, TracksService>();
        }
    }
}