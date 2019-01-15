namespace TeamBuilder.Data
{
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class TeamBuilderDbContext : DbContext
    {
        
        public TeamBuilderDbContext()
        { }

        public TeamBuilderDbContext(DbContextOptions options)
            : base(options)
        { }
        
        public DbSet<Event> Events { get; set; }
        public DbSet<EventTeam> EventTeams { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionConfiguration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
