using Microsoft.EntityFrameworkCore;
using PandaWebApp.Models;

namespace PandaWebApp.Data
{
    public class PandaDbContext : DbContext
    {
        public DbSet<Package> Packages { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public DbSet<User> Users { get; set; }
        public bool Any { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configurations.ConnectionString)
                    .UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .HasOne(x => x.Receipt)
                .WithOne(x => x.Package)
                .HasForeignKey<Package>(x => x.ReceiptId);
            
            modelBuilder.Entity<Receipt>()
                .HasOne(x => x.Package)
                .WithOne(x => x.Receipt)
                .HasForeignKey<Receipt>(x => x.PackageId);

            modelBuilder.Entity<Receipt>()
                .HasOne(x => x.Package)
                .WithOne(x => x.Receipt)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Package>()
                .HasOne(x => x.Receipt)
                .WithOne(x => x.Package)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
