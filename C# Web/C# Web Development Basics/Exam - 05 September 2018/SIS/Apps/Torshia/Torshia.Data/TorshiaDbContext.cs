using Microsoft.EntityFrameworkCore;
using Torshia.Models;

namespace Torshia.Data
{
    public class TorshiaDbContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<TaskSector> TasksSectors { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configurations.ConnectionString)
                    .UseLazyLoadingProxies();
            }
        }
    }
}