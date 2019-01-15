namespace IRunes.Data
{
    using Microsoft.EntityFrameworkCore;
    
    using Models;

    public class IRunesDbContext : DbContext
    {
        public IRunesDbContext()
        { }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configurations.ConnectionString)
                    .UseLazyLoadingProxies(true);
            }
        }
    }
}
