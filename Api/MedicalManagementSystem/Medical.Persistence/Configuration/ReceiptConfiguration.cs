using Medical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Persistence.Configuration
{
    public class ReceiptConfiguration
    {
        public ReceiptConfiguration(EntityTypeBuilder<Receipt> entity) 
        {
            entity.ToTable("receipts");
            entity.HasKey(r => r.ReceiptID);
            entity.Property(r => r.ReceiptID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            entity.Property(r => r.AppointmentID).IsRequired();
            entity.Property(r => r.Amount)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            entity.Property(r => r.PaymentStatus)
                .HasMaxLength(20)
                .IsRequired();
            entity.Property(r => r.PaymentDate).IsRequired();

            entity.HasOne(r => r.Appointment)
                .WithOne(a => a.Receipt)
                .HasForeignKey<Receipt>(r => r.ReceiptID);
        }
    }
}
