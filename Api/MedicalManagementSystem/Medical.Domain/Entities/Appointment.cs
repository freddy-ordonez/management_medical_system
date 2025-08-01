using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Medical.Domain.Entities
{
    public class Appointment
    {
        public int? AppointmentID { get; set; }
        public int? PatientID { get; set; }
        public int? DoctorID { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? Time { get; set; }
        public string? Status { get; set; }

        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
        public Receipt? Receipt { get; set; }
        public Notification? Notification { get; set; }
    }
}
