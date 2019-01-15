using Microsoft.EntityFrameworkCore;
using MishMash.App.Models;

namespace MishMash.App.Data
{
    public class MishMashDbContext : DbContext
    {
        public DbSet<Channel> Channels { get; set; }

        public DbSet<ChannelTag> ChannelsTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserChannel> UsersChannels { get; set; }

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
            modelBuilder.Entity<UserChannel>()
                .HasKey(x => new { x.UserId, x.ChannelId });

            modelBuilder.Entity<ChannelTag>()
                .HasKey(x => new { x.ChannelId, x.TagId });
        }
    }
}