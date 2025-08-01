using System.Collections.ObjectModel;

namespace Medical.Domain.Entities
{
    public class Patient
    {
        public int? PatientID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? BirthDate { get; set; }
        public string? Phone { get; set; }
        public bool Status { get; set; }

        public Collection<Appointment>? Appointments { get; set; }
    }
}