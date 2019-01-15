namespace TeamBuilder.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Username).IsRequired(true);
            builder.Property(u => u.Password).IsRequired(true);

            builder.HasIndex(u => u.Username).IsUnique(true);

            builder.Property(u => u.FirstName).HasMaxLength(25);
            builder.Property(u => u.LastName).HasMaxLength(25);
            builder.Property(u => u.Password).HasMaxLength(30);
        }
    }
}
