using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class RoleConfiguration
    {
        public RoleConfiguration(EntityTypeBuilder<Role> entity)
        {
            entity.ToTable("roles");
            entity.HasKey(r => r.RoleID);
            entity.Property(r => r.RoleID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(r => r.RoleName)
                .HasMaxLength(50)
                .IsRequired();

            entity.HasOne(r => r.User)
                .WithMany(u => u.Roles)
                .HasForeignKey(r => r.RoleID);
        }
    }
}
