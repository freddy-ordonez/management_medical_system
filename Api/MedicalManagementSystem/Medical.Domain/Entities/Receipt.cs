namespace Medical.Domain.Entities
{
    public class Receipt
    {
        public int? ReceiptID { get; set; }
        public int? AppointmentID { get; set; }
        public decimal? Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }

        public Appointment? Appointment { get; set; }
    }
}
