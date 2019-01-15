namespace MappingObjects.Data
{
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class MappingObjectsDbContext : DbContext
    {
        public MappingObjectsDbContext()
        { }

        public MappingObjectsDbContext(DbContextOptions options) 
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configurations.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
