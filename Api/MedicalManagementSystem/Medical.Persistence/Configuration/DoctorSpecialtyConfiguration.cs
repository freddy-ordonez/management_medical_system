using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class DoctorSpecialtyConfiguration
    {
        public DoctorSpecialtyConfiguration(EntityTypeBuilder<DoctorSpecialty> entity)
        {
            entity.ToTable("doctorspecialty");
            entity.HasKey(ds => ds.DoctorSpecialtyID);
            entity.Property(ds => ds.DoctorSpecialtyID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(ds => ds.DoctorID).IsRequired();
            entity.Property(ds => ds.SpecialtyID).IsRequired();

            entity.HasOne(ds => ds.Doctor)
                .WithMany(d => d.DoctorSpecialties)
                .HasForeignKey(ds => ds.DoctorID);

            entity.HasOne(ds => ds.Specialty)
                .WithMany(s => s.DoctorSpecialties)
                .HasForeignKey(ds => ds.SpecialtyID);
        }
    }
}
