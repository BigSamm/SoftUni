using System.Collections.Generic;
using System.Linq;
using Torshia.App.Services.Contracts;
using Torshia.Data;
using Torshia.Models;

namespace Torshia.App.Services
{
    public class ReportsService : IReportsService
    {
        private readonly TorshiaDbContext dbContext;

        public ReportsService(TorshiaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Report GetById(int id)
        {
            return this.dbContext.Reports.FirstOrDefault(x => x.Id == id);
        }

        public List<Report> GetAll()
        {
            return this.dbContext.Reports.ToList();
        }
    }
}
