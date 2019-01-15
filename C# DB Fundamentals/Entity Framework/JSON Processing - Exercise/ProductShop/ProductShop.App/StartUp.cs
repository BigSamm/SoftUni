namespace ProductShop.App
{
    using System;
    using System.IO;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Newtonsoft.Json;

    using Data;
    using Dtos;
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg => cfg.AddProfile<ProductShopProfile>());

            var context = new ProductShopContext();

            // 01. Import data
            //ImportUsers(context);
            //ImportProducts(context);
            //ImportCategories(context);
            //ImportCategoryProducts(context);

            // 02. Query and Export Data
            //GetProductsInRange(context);
            //GetSuccessfullySoldProducts(context);
            //GetCategoriesByProductsCount(context);
            GetUsersAndProducts(context);
        }

        private static void GetUsersAndProducts(ProductShopContext context)
        {
            var users = new
            {
                usersCount = context.Users
                    .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(ps => ps.Buyer != null))
                    .Count(),
                users = context.Users
                    .Where(u => u.ProductsSold.Count > 0 && u.ProductsSold.Any(ps => ps.Buyer != null))
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = new
                        {
                            count = u.ProductsSold.Count,
                            products = u.ProductsSold
                                .Select(p => new
                                {
                                    name = p.Name,
                                    price = p.Price
                                })
                        }
                    })
            };

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("../../../Json/users-and-products.json", json);
        }

        private static void GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .ProjectTo<CategoryProductsDto>()
                .OrderByDescending(c => c.ProductsCount);

            string json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText("../../../Json/categories-by-products.json", json);
        }

        private static void GetSuccessfullySoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Where(ps => ps.Buyer != null).Count() > 0)
                .ProjectTo<UserSoldProductsDto>()
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("../../../Json/users-sold-products.json.json", json);
        }

        private static void GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Include(p => p.Seller)
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .ProjectTo<ProductInRangeDto>()
                .OrderBy(p => p.Price);

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText("../../../Json/products-in-range.json", json);
        }

        private static void ImportCategoryProducts(ProductShopContext context)
        {
            var random = new Random();

            for (int productId = 1; productId <= 200; productId++)
            {
                int categoryId = random.Next(1, 12);

                var categoryProduct = new CategoryProduct
                {
                    CategoryId = categoryId,
                    ProductId = productId
                };

                context.CategoryProducts.Add(categoryProduct);
            }

            context.SaveChanges();
        }

        private static void ImportCategories(ProductShopContext context)
        {
            string json = File.ReadAllText("../../../Json/categories.json");
            Category[] categories = JsonConvert.DeserializeObject<Category[]>(json);

            context.AddRange(categories);
            context.SaveChanges();
        }

        private static void ImportProducts(ProductShopContext context)
        {
            string json = File.ReadAllText("../../../Json/products.json");
            Product[] products = JsonConvert.DeserializeObject<Product[]>(json);

            var random = new Random();

            int counter = 1;
            foreach (Product product in products)
            {
                int sellerId = random.Next(1, 57);
                product.SellerId = sellerId;

                if (counter % 20 == 0)
                {
                    product.BuyerId = null;
                }
                else
                {
                    int buyerId = random.Next(1, 57);
                    product.BuyerId = buyerId;
                }

                counter++;
            }

            context.AddRange(products);
            context.SaveChanges();
        }

        private static void ImportUsers(ProductShopContext context)
        {
            string json = File.ReadAllText("../../../Json/users.json");
            User[] users = JsonConvert.DeserializeObject<User[]>(json);

            context.AddRange(users);
            context.SaveChanges();
        }
    }
}