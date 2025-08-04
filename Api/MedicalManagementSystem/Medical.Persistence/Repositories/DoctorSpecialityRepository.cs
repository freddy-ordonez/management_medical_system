using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class DoctorSpecialityRepository : RepositoryBase<DoctorSpecialty>, IDoctorSpecialityRepository
    {
        public DoctorSpecialityRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateDoctorSpeciality(DoctorSpecialty doctorSpecialty) => Create(doctorSpecialty);

        public void DeleteDoctorSpeciality(DoctorSpecialty doctorSpecialty) => Delete(doctorSpecialty);

        public async Task<IEnumerable<DoctorSpecialty>> FindByIdDoctorSpecialityAsync(int doctorId, bool trackChanges) =>
            await FindByCondition(ds => ds.DoctorID.Equals(doctorId), trackChanges)
                    .Include(ds => ds.Specialty)
                    .ToListAsync();
    }
}
