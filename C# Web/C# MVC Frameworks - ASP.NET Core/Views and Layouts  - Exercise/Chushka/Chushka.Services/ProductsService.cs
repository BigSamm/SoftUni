using Chushka.Services.Contracts;
using Chushka.Data;
using Chushka.Models;
using Chushka.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Chushka.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ChushkaDbContext dbContext;

        public ProductsService(ChushkaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Product GetById(int id)
        {
            return this.dbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetAll()
        {
            return this.dbContext.Products.ToList();
        }

        public int Register(string name, decimal price, string description, ProductType type)
        {
            var product = new Product
            {
                Description = description,
                Name = name,
                Price = price,
                Type = type,
            };

            this.dbContext.Products.Add(product);
            this.dbContext.SaveChanges();

            return product.Id;
        }

        public void Update(Product product, string name, decimal price, string description, ProductType type)
        {
            product.Name = name;
            product.Price = price;
            product.Description = description;
            product.Type = type;

            this.dbContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            this.dbContext.Products.Remove(product);
            this.dbContext.SaveChanges();
        }
    }
}
