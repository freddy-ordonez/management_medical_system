using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> FinAllPatientAsync(bool trackChanges);
        Task<Patient?> FinPatientByIdAsync(int id, bool trackChanges);
        void CreatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}
