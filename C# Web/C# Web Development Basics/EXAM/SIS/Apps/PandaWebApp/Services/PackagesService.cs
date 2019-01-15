namespace PandaWebApp.Services
{
    using Contracts;
    using PandaWebApp.Data;
    using PandaWebApp.Models;
    using PandaWebApp.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PackagesService : IPackagesService
    {
        private readonly PandaDbContext dbContext;

        public PackagesService(PandaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Package GetById(int id)
        {
            return this.dbContext.Packages.FirstOrDefault(x => x.Id == id);
        }

        public List<Package> GetAllByStatus(PackageStatus status)
        {
            return this.dbContext.Packages.Where(x => x.Status == status).ToList();
        }

        public List<Package> GetAllByStatusAndUsername(PackageStatus status, string username)
        {
            return this.dbContext.Packages.Where(x => x.Status == status && x.Recipient.Username == username).ToList();
        }

        public int Register(string description, double weight, string shippingAddress, int userId)
        {
            var package = new Package
            {
                Description = description,
                Weight = weight,
                ShippingAddress = shippingAddress,
                RecipientId = userId,
                Status = PackageStatus.Pending,
                EstimatedDeliveryDate = null,
            };

            this.dbContext.Packages.Add(package);
            this.dbContext.SaveChanges();

            return package.Id;
        }

        public void Ship(Package package)
        {
            var random = new Random();

            package.Status = PackageStatus.Shipped;
            package.EstimatedDeliveryDate = DateTime.UtcNow.AddDays(random.Next(20, 41));

            this.dbContext.SaveChanges();
        }

        public void Deliver(Package package)
        {
            package.Status = PackageStatus.Delivered;

            this.dbContext.SaveChanges();       
        }

        public void Acquire(Package package)
        {
            package.Status = PackageStatus.Acquired;

            this.dbContext.SaveChanges();
        }
    }
}
