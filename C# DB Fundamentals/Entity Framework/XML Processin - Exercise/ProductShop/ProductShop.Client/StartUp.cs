namespace ProductShop.Client
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.EntityFrameworkCore;

    using Data;
    using Models;

    public class StartUp
    {
        static void Main()
        {
            var context = new ProductShopDbContext();

            // 02. Import Data
            //ImportUsers(context);
            //ImportProducts(context);
            //ImportCategories(context);
            //ImportCategoryProducts(context);

            // 03. Query and Export Data
            //GetProductsInRange(context);
            //GetSoldProducts(context);
            //GetCategoriesByProductsCount(context);
            //GetUsersAndProducts(context);
        }

        private static void GetUsersAndProducts(ProductShopDbContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderByDescending(u => u.ProductsSold.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = u.ProductsSold
                });

            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("users", new XAttribute("count", users.Count())));

            foreach (var user in users)
            {
                var soldProductsElement = new XElement("sold-products", new XAttribute("count", user.soldProducts.Count));

                foreach (var product in user.soldProducts)
                {
                    var productElement = new XElement("product",
                        new XAttribute("name", product.Name),
                        new XAttribute("price", $"{product.Price:f2}"));

                    soldProductsElement.Add(productElement);
                }

                XElement userElement = new XElement("user");

                if (user.firstName != null)
                    userElement.Add(new XAttribute("first-name", user.firstName));

                userElement.Add(new XAttribute("last-name", user.lastName));

                if (user.age != null)
                    userElement.Add(new XAttribute("age", user.age));

                userElement.Add(soldProductsElement);

                xmlDoc.Root.Add(userElement);
            }

            xmlDoc.Save("users-and-products.xml");
        }

        private static void GetCategoriesByProductsCount(ProductShopDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("categories"));

            var categories = context.Categories
                .Include(c => c.CategoryProducts)
                .ThenInclude(cp => cp.Product)
                .Select(c => new
                {
                    name = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    totalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
                })
                .OrderByDescending(c => c.productsCount);

            foreach (var cat in categories)
            {
                var catElement = new XElement("category",
                    new XAttribute("name", cat.name));
                
                catElement.Add(new XElement("products-count", cat.productsCount));
                catElement.Add(new XElement("average-price", cat.averagePrice));
                catElement.Add(new XElement("total-revenue", cat.totalRevenue));

                xmlDoc.Root.Add(catElement);
            }

            xmlDoc.Save("categories-by-products.xml");
        }

        private static void GetSoldProducts(ProductShopDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("users"));

            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                });

            foreach (var user in users)
            {
                var soldProductsElement = new XElement("sold-products");

                foreach (var product in user.soldProducts)
                {
                    var productElement = new XElement("product",
                        new XElement("name", product.Name),
                        new XElement("price", $"{product.Price:f2}"));

                    soldProductsElement.Add(productElement);
                }

                XElement userElement = new XElement("user");

                if (user.firstName != null)
                    userElement.Add(new XAttribute("first-name", user.firstName));

                userElement.Add(new XAttribute("last-name", user.lastName));

                userElement.Add(soldProductsElement);

                xmlDoc.Root.Add(userElement);
            }

            xmlDoc.Save("users-sold-products.xml");
        }

        private static void GetProductsInRange(ProductShopDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("products"));

            var products = context.Products
                .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    buyer = p.Buyer.FirstName ?? "" + " " + p.Buyer.LastName
                });

            foreach (var prod in products)
            {
                XElement product = new XElement("product",
                    new XAttribute("name", prod.name),
                    new XAttribute("price", prod.price),
                    new XAttribute("buyer", prod.buyer));

                xmlDoc.Root.Add(product);
            }

            xmlDoc.Save("products-in-range.xml");
        }

        private static void ImportCategoryProducts(ProductShopDbContext context)
        {
            var random = new Random();

            for (int productId = 1; productId <= context.Products.Count(); productId++)
            {
                int categoryId = random.Next(1, context.Categories.Count() + 1);

                var categoryProduct = new CategoryProduct
                {
                    CategoryId = categoryId,
                    ProductId = productId
                };

                context.CategoryProducts.Add(categoryProduct);
            }

            context.SaveChanges();
        }

        private static void ImportCategories(ProductShopDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                            @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\categories.xml");

            var categories = xmlDoc.Root.Elements()
                .Select(c => new { name = c.Element("name").Value });

            foreach (var cat in categories)
            {
                var currentCat = new Category { Name = cat.name };

                context.Categories.Add(currentCat);
            }

            context.SaveChanges();
        }

        private static void ImportProducts(ProductShopDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                            @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\products.xml");

            var products = xmlDoc.Root.Elements()
                .Select(p => new
                {
                    name = p.Element("name").Value,
                    price = p.Element("price").Value
                });

            var random = new Random();

            int counter = 0;
            foreach (var product in products)
            {
                decimal price = decimal.Parse(product.price);

                int maxIdValue = context.Users.Count() + 1;
                int? buyerId = random.Next(1, maxIdValue);
                int sellerId = random.Next(1, maxIdValue);

                if (counter % 20 == 0 && counter != 0)
                    buyerId = null;

                var currentProduct = new Product
                {
                    Name = product.name,
                    Price = price,
                    BuyerId = buyerId,
                    SellerId = sellerId
                };

                context.Products.Add(currentProduct);

                counter++;
            }

            context.SaveChanges();
        }

        private static void ImportUsers(ProductShopDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                            @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\users.xml");

            var users = xmlDoc.Root.Elements()
                .Select(u => new
                {
                    firstName = u.Attribute("firstName")?.Value,
                    lastName = u.Attribute("lastName").Value,
                    ageStr = u.Attribute("age")?.Value
                });

            foreach (var user in users)
            {
                int? age = user.ageStr != null ? int.Parse(user.ageStr) : (int?)null;

                var currentUser = new User
                {
                    FirstName = user.firstName,
                    LastName = user.lastName,
                    Age = age
                };

                context.Users.Add(currentUser);
            }

            context.SaveChanges();
        }
    }
}