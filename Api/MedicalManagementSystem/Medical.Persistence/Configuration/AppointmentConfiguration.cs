using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class AppointmentConfiguration
    {
        public AppointmentConfiguration(EntityTypeBuilder<Appointment> entity) 
        {
            entity.ToTable("appointments");
            entity.HasKey(a => a.PatientID);
            entity.Property(a => a.PatientID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(a => a.PatientID).IsRequired();
            entity.Property(a => a.DoctorID).IsRequired();
            entity.Property(a => a.Date).IsRequired();
            entity.Property(a => a.Time).IsRequired();
            entity.Property(a => a.Status)
                .HasMaxLength(20)
                .IsRequired();

            entity.HasOne(a => a.Receipt)
                .WithOne(b => b.Appointment)
                .HasForeignKey<Appointment>(a => a.AppointmentID);


            entity.HasOne(a => a.Notification)
                .WithOne(n => n.Appointment)
                .HasForeignKey<Appointment>(a => a.AppointmentID);

            entity.HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorID);

            entity.HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(aa => aa.PatientID);


        }
    }
}
