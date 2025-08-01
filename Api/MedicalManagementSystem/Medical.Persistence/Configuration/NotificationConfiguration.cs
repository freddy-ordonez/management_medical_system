using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class NotificationConfiguration
    {
        public NotificationConfiguration(EntityTypeBuilder<Notification> entity)
        {
            entity.ToTable("notifications");
            entity.HasKey(n => n.NotificationID);
            entity.Property(n => n.NotificationID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(n => n.AppointmentID).IsRequired();
            entity.Property(n => n.Status)
                .HasMaxLength(20)
                .IsRequired();
            entity.Property(n => n.Type)
                .HasMaxLength(50)
                .IsRequired();
            entity.Property(n => n.SentDate).IsRequired();

            entity.HasOne(n => n.Appointment)
                .WithOne(n => n.Notification)
                .HasForeignKey<Notification>(n => n.NotificationID);
        }
    }
}
