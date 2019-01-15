namespace CarDealer.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.EntityFrameworkCore;

    using Data;
    using Models;

    public class StartUp
    {
        static void Main()
        {
            var context = new CarDealerDbContext();

            // 02. Import Data
            //ImportSuppliers(context);
            //ImportParts(context);
            //ImportCars(context);
            //ImportPartCars(context);
            //ImportCustomers(context);
            //ImportSales(context);

            // 03. Query and Export Data
            //GetCarsWithDistance(context);
            //GetCarsFromMakeFerrari(context);
            //GetLocalSuppliers(context);
            //GetCarsWithTheirListOfParts(context);
            //GetTotalSalesByCustomer(context);
            //GetSalesWithAppliedDiscount(context);
        }

        private static void GetSalesWithAppliedDiscount(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("sales"));

            var sales = context.Sales
                .Select(s => new
                {
                    car = s.Car,
                    customerName = s.Customer.Name,
                    discount = s.Discount,
                    price = s.Car.PartCars.Sum(pc => pc.Part.Price)
                });

            foreach (var sale in sales)
            {
                var saleElement = new XElement("sale");

                Car car = sale.car;
                saleElement.Add(new XElement("car",
                    new XAttribute("make", car.Make),
                    new XAttribute("model", car.Model),
                    new XAttribute("travelled-distance", car.TravelledDistance)));

                saleElement.Add(new XElement("customer-name", sale.customerName));

                saleElement.Add(new XElement("discount", sale.discount / 100));

                saleElement.Add(new XElement("price", sale.price));

                decimal priceWithDiscount = sale.price * (decimal)(1 - (sale.discount / 100));
                saleElement.Add(new XElement("price-with-discount", priceWithDiscount));

                xmlDoc.Root.Add(saleElement);
            }

            xmlDoc.Save("sales-discounts.xml");
        }

        private static void GetTotalSalesByCustomer(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("customers"));

            var customers = context.Customers
                .Where(c => c.Sales.Count > 0)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    spentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price))
                })
                .OrderByDescending(c => c.spentMoney)
                .ThenByDescending(c => c.boughtCars);

            foreach (var cust in customers)
            {
                var custElement = new XElement("customer",
                    new XAttribute("full-name", cust.fullName),
                    new XAttribute("bought-cars", cust.boughtCars),
                    new XAttribute("spent-money", $"{cust.spentMoney:f2}"));

                xmlDoc.Root.Add(custElement);
            }

            xmlDoc.Save("customers-total-sales.xml");
        }

        private static void GetCarsWithTheirListOfParts(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("cars"));

            var cars = context.Cars.Include(c => c.PartCars).ThenInclude(pc => pc.Part);
            foreach (var car in cars)
            {
                var carElement = new XElement("car",
                    new XAttribute("make", car.Make),
                    new XAttribute("model", car.Model),
                    new XAttribute("travelled-distance", car.TravelledDistance));

                var partsElement = new XElement("parts");
                IEnumerable<Part> parts = car.PartCars.Select(pc => pc.Part);

                foreach (Part part in parts)
                {
                    partsElement.Add(new XElement("part",
                        new XAttribute("name", part.Name),
                        new XAttribute("price", part.Price)));
                }

                carElement.Add(partsElement);

                xmlDoc.Root.Add(carElement);
            }

            xmlDoc.Save("cars-and-parts.xml");
        }

        private static void GetLocalSuppliers(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("suppliers"));

            var suppliers = context.Suppliers
                .Include(s => s.Parts)
                .Where(s => s.IsImporter == false);

            foreach (var supplier in suppliers)
            {
                var supplierElement = new XElement("suplier",
                    new XAttribute("id", supplier.SupplierId),
                    new XAttribute("name", supplier.Name),
                    new XAttribute("parts-count", supplier.Parts.Count));

                xmlDoc.Root.Add(supplierElement);
            }

            xmlDoc.Save("local-suppliers.xml");
        }

        private static void GetCarsFromMakeFerrari(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("cars"));

            var cars = context.Cars
                .Where(c => c.Make == "Ferrari")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance);

            foreach (var car in cars)
            {
                var carElement = new XElement("car",
                    new XAttribute("id", car.CarId),
                    new XAttribute("model", car.Model),
                    new XAttribute("travelled-distance", car.TravelledDistance));

                xmlDoc.Root.Add(carElement);
            }

            xmlDoc.Save("ferrari-cars.xml");
        }

        private static void GetCarsWithDistance(CarDealerDbContext context)
        {
            var xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("cars"));

            var cars = context.Cars
                .Where(c => c.TravelledDistance > 2_000_000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model);

            foreach (var car in cars)
            {
                var carElement = new XElement("car",
                    new XElement("make", car.Make),
                    new XElement("model", car.Model),
                    new XElement("travelled-distance", car.TravelledDistance));

                xmlDoc.Root.Add(carElement);
            }

            xmlDoc.Save("cars.xml");
        }

        private static void ImportSales(CarDealerDbContext context)
        {
            var discounts = new int[] { 0, 5, 10, 15, 20, 30, 40, 50 };
            var random = new Random();

            int salesCount = random.Next(100, 200);
            for (int i = 0; i < salesCount; i++)
            {
                int carId = random.Next(1, context.Cars.Count() + 1);
                int customerId = random.Next(1, context.Customers.Count() + 1);

                int discountIndex = random.Next(0, discounts.Length);
                int discount = discounts[discountIndex];

                Customer customer = context.Customers.Find(customerId);
                if (customer.IsYoungDriver)
                    discount += 5;

                var sale = new Sale
                {
                    CarId = carId,
                    CustomerId = customerId,
                    Discount = discount
                };

                context.Sales.Add(sale);
            }

            context.SaveChanges();
        }

        private static void ImportCustomers(CarDealerDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\customers.xml");

            var customers = xmlDoc.Root.Elements()
                .Select(c => new
                {
                    name = c.Attribute("name").Value,
                    birthDateStr = c.Element("birth-date").Value,
                    isYoungDriverStr = c.Element("is-young-driver").Value
                });

            foreach (var cust in customers)
            {
                DateTime birthDate = DateTime.Parse(cust.birthDateStr);
                bool isYoungDriver = bool.Parse(cust.isYoungDriverStr);

                var customer = new Customer
                {
                    Name = cust.name,
                    BirthDate = birthDate,
                    IsYoungDriver = isYoungDriver
                };

                context.Customers.Add(customer);
            }

            context.SaveChanges();
        }

        private static void ImportPartCars(CarDealerDbContext context)
        {
            var random = new Random();

            for (int carId = 1; carId <= context.Cars.Count(); carId++)
            {
                var partsList = new List<int>();
                int partsCount = random.Next(10, 20);

                for (int i = 0; i < partsCount; i++)
                {
                    int partId = random.Next(1, context.Parts.Count() + 1);
                    partsList.Add(partId);
                }

                partsList = partsList.Distinct().ToList();

                for (int index = 0; index < partsList.Count; index++)
                {
                    int partId = partsList[index];

                    var partCar = new PartCar
                    {
                        CarId = carId,
                        PartId = partId
                    };

                    context.PartCars.Add(partCar);
                }
            }

            context.SaveChanges();
        }

        private static void ImportCars(CarDealerDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\cars.xml");

            var cars = xmlDoc.Root.Elements()
                .Select(c => new
                {
                    make = c.Element("make").Value,
                    model = c.Element("model").Value,
                    travelledDistanceStr = c.Element("travelled-distance").Value
                });

            foreach (var car in cars)
            {
                long travelledDistance = long.Parse(car.travelledDistanceStr);

                var currentCar = new Car
                {
                    Make = car.make,
                    Model = car.model,
                    TravelledDistance = travelledDistance     
                };

                context.Cars.Add(currentCar);
            }

            context.SaveChanges();
        }

        private static void ImportParts(CarDealerDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\parts.xml");

            var parts = xmlDoc.Root.Elements()
                .Select(p => new
                {
                    name = p.Attribute("name").Value,
                    priceStr = p.Attribute("price").Value,
                    quantityStr = p.Attribute("quantity").Value
                });

            var random = new Random();

            foreach (var part in parts)
            {
                decimal price = decimal.Parse(part.priceStr);
                int quantity = int.Parse(part.quantityStr);
                int supplierId = random.Next(1, context.Suppliers.Count() + 1);

                var currentPart = new Part
                {
                    Name = part.name,
                    Price = price,
                    Quantity = quantity,
                    SupplierId = supplierId                    
                };

                context.Parts.Add(currentPart);
            }

            context.SaveChanges();
        }

        private static void ImportSuppliers(CarDealerDbContext context)
        {
            XDocument xmlDoc = XDocument.Load(
                @"D:\SoftUni\C# DB Fundamentals\Entity Framework\XML Processin - Exercise\Resources\suppliers.xml");

            var suppliers = xmlDoc.Root.Elements()
                .Select(s => new
                {
                    name = s.Attribute("name").Value,
                    isImporterStr = s.Attribute("is-importer").Value
                });

            foreach (var supp in suppliers)
            {
                bool isImporter = bool.Parse(supp.isImporterStr);

                var supplier = new Supplier
                {
                    Name = supp.name,
                    IsImporter = isImporter
                };

                context.Suppliers.Add(supplier);
            }

            context.SaveChanges();
        }
    }
}