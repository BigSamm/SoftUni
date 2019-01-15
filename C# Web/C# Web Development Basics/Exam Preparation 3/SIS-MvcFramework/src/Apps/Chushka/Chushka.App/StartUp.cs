using Chushka.App.Services;
using Chushka.App.Services.Contracts;
using SIS.MvcFramework;
using SIS.MvcFramework.Services;

namespace Chushka.App
{
    public class StartUp : IMvcApplication
    {
        public MvcFrameworkSettings Configure()
        {
            return new MvcFrameworkSettings();
        }

        public void ConfigureServices(IServiceCollection collection)
        {
            collection.AddService<IUsersService, UsersService>();
            collection.AddService<IProductsService, ProductsService>();
            collection.AddService<IOrdersService, OrdersService>();
        }
    }
}
