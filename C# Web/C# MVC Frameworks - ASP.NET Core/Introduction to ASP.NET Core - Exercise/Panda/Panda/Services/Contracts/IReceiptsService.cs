using Microsoft.AspNetCore.Identity;
using Panda.Models;
using System.Collections.Generic;

namespace Panda.Services.Contracts
{
    public interface IReceiptsService
    {
        Receipt GetById(int id);

        List<Receipt> GetAllByUsername(string username);

        void Register(Package package, User user);
    }
}
