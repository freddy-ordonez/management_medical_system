using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IDoctorSpecialityRepository
    {
        Task<IEnumerable<DoctorSpecialty>> FindByIdDoctorSpeciality(int doctorId, bool trackChanges);
        void CreateDoctorSpeciality(DoctorSpecialty doctorSpecialty);
        void DeleteDoctorSpeciality(DoctorSpecialty doctorSpecialty);
    }
}
