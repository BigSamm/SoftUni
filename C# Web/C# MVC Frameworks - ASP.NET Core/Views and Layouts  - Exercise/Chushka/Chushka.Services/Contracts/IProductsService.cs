using Chushka.Models;
using Chushka.Models.Enums;
using System.Collections.Generic;

namespace Chushka.Services.Contracts
{
    public interface IProductsService
    {
        Product GetById(int id);

        List<Product> GetAll();

        int Register(string name, decimal price, string description, ProductType type);

        void Update(Product product, string name, decimal price, string description, ProductType type);

        void Delete(Product product);
    }
}
