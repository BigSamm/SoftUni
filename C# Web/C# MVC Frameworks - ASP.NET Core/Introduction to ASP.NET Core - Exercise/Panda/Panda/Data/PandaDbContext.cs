using Microsoft.EntityFrameworkCore;
using Panda.Models;

namespace Panda.Data
{
    public class PandaDbContext : DbContext
    {
        public PandaDbContext()
        { }

        public PandaDbContext(DbContextOptions<PandaDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Receipt> Receipts { get; set; }
        
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

            base.OnModelCreating(modelBuilder);
        }
    }
}
