﻿namespace Medical.Domain.Entities
{
    public class Doctor
    {
        public int? DoctorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool Status { get; set; }

        public ICollection<DoctorSpecialty>? DoctorSpecialties { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
