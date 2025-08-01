using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class SpecialtyConfiguration
    {
        public SpecialtyConfiguration(EntityTypeBuilder<Specialty> entity)
        {
            entity.ToTable("spacilaties");
            entity.HasKey(s => s.SpecialtyID);
            entity.Property(s => s.SpecialtyID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(s => s.SpecialtyName)
                .HasMaxLength(100)
                .IsRequired();

            entity.HasMany(s => s.DoctorSpecialties)
                .WithOne(ds => ds.Specialty)
                .HasForeignKey(s => s.SpecialtyID);
        }
    }
}
