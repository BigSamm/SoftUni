namespace CarDealer.App
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Newtonsoft.Json;

    using Data;
    using Dtos;
    using Models;

    public class StartUp
    {
        static void Main()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<CarDealerProfile>());

            var context = new CarDealerDbContext();

            // 02. Import Data
            //ImportSuppliers(context);
            //ImportParts(context);
            //ImportCars(context);
            //ImportPartCars(context);
            //ImportCustomers(context);
            //ImportSales(context);

            // 03. Query and Export Data
            //GetOrderedCustomers(context);
            //GetCarsFromMakeToyota(context);
            //GetLocalSuppliers(context);
            //GetCarsWithTheirListOfParts(context);
            //GetTotalSalesByCustomer(context);
            //GetSalesWithAppliedDiscount(context);
        }

        private static void GetSalesWithAppliedDiscount(CarDealerDbContext context)
        {
            var sales = context.Sales
                .Select(s => new
                {
                    car = new
                    {
                        s.Car.Make,
                        s.Car.Model,
                        s.Car.TravelledDistance
                    },
                    customerName = s.Customer.Name,
                    s.Discount,
                    price = s.Car.PartCars.Sum(pc => pc.Part.Price),
                    priceWithDiscount = (double)s.Car.PartCars.Sum(pc => pc.Part.Price) * (1 - s.Discount)
                });

            string json = JsonConvert.SerializeObject(sales, Formatting.Indented);
            File.WriteAllText("../../../Json/sales-discounts.json", json);
        }

        private static void GetTotalSalesByCustomer(CarDealerDbContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Count > 0)
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    spentMoney = $"{c.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price)):f2}"
                })
                .OrderByDescending(c => c.spentMoney)
                .ThenByDescending(c => c.boughtCars);

            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText("../../../Json/customers-total-sales.json", json);
        }

        private static void GetCarsWithTheirListOfParts(CarDealerDbContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        c.TravelledDistance
                    },
                    parts = c.PartCars
                        .Select(pc => pc.Part)
                        .Select(p => new
                        {
                            p.Name,
                            p.Price
                        })
                });
            
            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            File.WriteAllText("../../../Json/cars-and-parts.json", json);
        }

        private static void GetLocalSuppliers(CarDealerDbContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .ProjectTo<NotImporterSupplierDto>();
            
            string json = JsonConvert.SerializeObject(suppliers, Formatting.Indented);
            File.WriteAllText("../../../Json/local-suppliers.json", json);
        }

        private static void GetCarsFromMakeToyota(CarDealerDbContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ProjectTo<ToyotaCarDto>();

            string json = JsonConvert.SerializeObject(cars, Formatting.Indented);
            File.WriteAllText("../../../Json/toyota-cars.json", json);
        }

        private static void GetOrderedCustomers(CarDealerDbContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver);

            string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText("../../../Json/ordered-customers.json", json);
        }

        private static void ImportSales(CarDealerDbContext context)
        {
            var discounts = new double[] { 0, .05, .1, .15, .2, .3, .4, .5 };
            var random = new Random();

            int salesCount = random.Next(100, 201);
            for (int i = 0; i < salesCount; i++)
            {
                int carId = random.Next(1, 359);
                int customerId = random.Next(1, 31);
                double discount = discounts[random.Next(0, discounts.Length)];

                var sale = new Sale
                {
                    Discount = discount,
                    CarId = carId,
                    CustomerId = customerId
                };

                context.Sales.Add(sale);
            }

            context.SaveChanges();
        }

        private static void ImportCustomers(CarDealerDbContext context)
        {
            string json = File.ReadAllText("../../../Json/customers.json");
            Customer[] customers = JsonConvert.DeserializeObject<Customer[]>(json);

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private static void ImportPartCars(CarDealerDbContext context)
        {
            var random = new Random();

            for (int carId = 1; carId <= 358; carId++)
            {
                var partsIds = new List<int>();

                int partsCount = random.Next(10, 21);
                for (int i = 0; i < partsCount; i++)
                {
                    int partId = random.Next(1, 132);
                    partsIds.Add(partId);
                }

                partsIds = partsIds.Distinct().ToList();

                foreach (int partId in partsIds)
                {
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
            string json = File.ReadAllText("../../../Json/cars.json");
            Car[] cars = JsonConvert.DeserializeObject<Car[]>(json);

            context.Cars.AddRange(cars);
            context.SaveChanges();
        }

        private static void ImportParts(CarDealerDbContext context)
        {
            string json = File.ReadAllText("../../../Json/parts.json");
            Part[] parts = JsonConvert.DeserializeObject<Part[]>(json);

            var random = new Random();

            foreach (Part part in parts)
            {
                int supplierId = random.Next(1, 32);
                part.SupplierId = supplierId;
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();
        }

        private static void ImportSuppliers(CarDealerDbContext context)
        {
            string json = File.ReadAllText("../../../Json/suppliers.json");
            Supplier[] suppliers = JsonConvert.DeserializeObject<Supplier[]>(json);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
        }
    }
}