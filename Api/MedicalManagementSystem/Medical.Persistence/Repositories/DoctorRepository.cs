using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Medical.Persistence.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateDoctor(Doctor doctor) => Create(doctor);

        public void DeleteDoctor(Doctor doctor) => Delete(doctor);

        public async Task<IEnumerable<Doctor>> FindAllDoctorAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                    .ToListAsync();

        public async Task<Doctor?> FindByIddDoctor(int id, bool trackChanges) =>
            await FindByCondition(d => d.DoctorID.Equals(id), trackChanges)
            .SingleOrDefaultAsync();
    }
}
