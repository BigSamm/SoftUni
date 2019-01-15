using PandaWebApp.Models;
using System.Collections.Generic;

namespace PandaWebApp.Services.Contracts
{
    public interface IReceiptsService
    {
        Receipt GetById(int id);

        List<Receipt> GetAllByUsername(string username);

        void Register(Package package, User user);
    }
}
