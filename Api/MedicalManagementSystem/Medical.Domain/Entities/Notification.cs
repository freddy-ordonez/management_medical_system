namespace Medical.Domain.Entities
{
    public class Notification
    {
        public int? NotificationID { get; set; }
        public int? AppointmentID { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public DateTime? SentDate { get; set; }

        public Appointment? Appointment { get; set; }
    }
}
