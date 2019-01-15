namespace MappingObjects.Services
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;

    public class DbInitializerService : IDbInitializerService
    {
        private readonly MappingObjectsDbContext context;

        public DbInitializerService(MappingObjectsDbContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
