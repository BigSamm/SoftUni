namespace PandaWebApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using PandaWebApp.Data;
    using PandaWebApp.Models;
    using PandaWebApp.Models.Enums;

    public class ReceiptsService : IReceiptsService
    {
        private readonly PandaDbContext dbContext;

        public ReceiptsService(PandaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Receipt> GetAllByUsername(string username)
        {
            return this.dbContext.Receipts.Where(x => x.Recipient.Username == username).ToList();
        }

        public Receipt GetById(int id)
        {
            return this.dbContext.Receipts.FirstOrDefault(x => x.Id == id);
        }

        public void Register(Package package, User user)
        {
            var receipt = new Receipt
            {
                PackageId = package.Id,
                RecipientId = user.Id,
                IssuedOn = DateTime.UtcNow,
                Fee = (decimal)(package.Weight * 2.67),
            };

            this.dbContext.Receipts.Add(receipt);
            this.dbContext.SaveChanges();
        }
    }
}
