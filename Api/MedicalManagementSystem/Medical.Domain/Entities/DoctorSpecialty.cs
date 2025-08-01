namespace Medical.Domain.Entities
{
    public class DoctorSpecialty
    {
        public int? DoctorSpecialtyID { get; set; }
        public int? DoctorID { get; set; }
        public int? SpecialtyID { get; set; }

        public Doctor? Doctor { get; set; }
        public Specialty? Specialty { get; set; }
    }
}
