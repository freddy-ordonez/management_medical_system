using System.Collections.ObjectModel;

namespace Medical.Domain.Entities
{
    public class Specialty
    {
        public int? SpecialtyID { get; set; }
        public string? SpecialtyName { get; set; }

        public Collection<DoctorSpecialty>? DoctorSpecialties { get; set; }
    }
}
