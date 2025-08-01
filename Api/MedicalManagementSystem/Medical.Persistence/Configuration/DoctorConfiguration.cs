using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class DoctorConfiguration
    {
        public DoctorConfiguration(EntityTypeBuilder<Doctor> entity)
        {
            entity.ToTable("doctors");
            entity.HasKey(d => d.DoctorID);
            entity.Property(d => d.DoctorID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(d => d.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(d => d.LastName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(d => d.Email)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(d => d.Phone)
                .HasMaxLength(20)
                .IsRequired();
            entity.Property(d => d.Status).IsRequired();

            entity.HasMany(d => d.DoctorSpecialties)
                .WithOne(ds => ds.Doctor)
                .HasForeignKey(d => d.DoctorID);

            entity.HasMany(d => d.Appointments)
                .WithOne(a => a.Doctor)
                .HasForeignKey(d => d.DoctorID);
        }
    }
}
