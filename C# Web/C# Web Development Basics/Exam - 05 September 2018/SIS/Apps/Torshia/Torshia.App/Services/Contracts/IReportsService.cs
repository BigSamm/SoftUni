using System.Collections.Generic;
using Torshia.Models;

namespace Torshia.App.Services.Contracts
{
    public interface IReportsService
    {
        Report GetById(int id);

        List<Report> GetAll();
    }
}