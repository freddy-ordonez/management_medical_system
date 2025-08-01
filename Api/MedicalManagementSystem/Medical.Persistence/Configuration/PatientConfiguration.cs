using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class PatientConfiguration
    {
        public PatientConfiguration(EntityTypeBuilder<Patient> entity)
        {
            entity.ToTable("patients");
            entity.HasKey(p => p.PatientID);
            entity.Property(p => p.PatientID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(p => p.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(p => p.LastName)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(p => p.BirthDate).IsRequired();
            entity.Property(p => p.Status).IsRequired();
            entity.Property(p => p.Email)
                .HasMaxLength(100)
                .IsRequired();
            entity.Property(p => p.Phone)
                .HasMaxLength(20)
                .IsRequired();

            entity.HasMany(p => p.Appointments)
                .WithOne(a => a.Patient)
                .HasForeignKey(p => p.PatientID);
        }
    }
}
