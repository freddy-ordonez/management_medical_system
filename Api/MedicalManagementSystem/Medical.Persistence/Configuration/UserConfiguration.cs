using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entity)
        {
            entity.ToTable("users");
            entity.HasKey(u => u.UserID);
            entity.Property(u => u.UserID).IsRequired();
            entity.Property(u => u.RoleID).IsRequired();
            entity.Property(u => u.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(u => u.LastName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(u => u.Status).IsRequired();
            entity.Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(u => u.PasswordHash)
                .HasMaxLength(255)
                .IsRequired();

            entity.HasMany(u => u.Roles)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.RoleID);
        }
    }
}
