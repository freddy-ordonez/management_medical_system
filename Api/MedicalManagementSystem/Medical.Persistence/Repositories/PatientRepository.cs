using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreatePatient(Patient patient) => Create(patient);

        public void DeletePatient(Patient patient) => Delete(patient);

        public async Task<IEnumerable<Patient>> FinAllPatientAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                    .ToListAsync();

        public async Task<Patient?> FinPatientByIdAsync(int id, bool trackChanges) => 
            await FindByCondition(p => p.PatientID.Equals(id), trackChanges)
                    .SingleOrDefaultAsync();
    }
}
