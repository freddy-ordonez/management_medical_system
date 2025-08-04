using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> FindAllDoctorAsync(bool trackChanges);
        Task<Doctor?> FindByIddDoctor(int id, bool trackChanges);
        void CreateDoctor(Doctor doctor);
        void DeleteDoctor(Doctor doctor);
    }
}
