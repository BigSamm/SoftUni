using Panda.Models;
using Panda.Models.Enums;
using System.Collections.Generic;

namespace Panda.Services.Contracts
{
    public interface IPackagesService
    {
        Package GetById(int id);

        List<Package> GetAllByStatus(PackageStatus status);

        List<Package> GetAllByStatusAndUsername(PackageStatus status, string username);
        
        int Register(string description, double weight, string shippingAddress, int userId);

        void Ship(Package package);

        void Deliver(Package package);

        void Acquire(Package package);
    }
}
