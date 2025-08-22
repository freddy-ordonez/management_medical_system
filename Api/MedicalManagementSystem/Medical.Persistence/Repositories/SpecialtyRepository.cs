using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class SpecialtyRepository : RepositoryBase<Specialty>, ISpecialtyRepository
    {
        public SpecialtyRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateSpecialty(Specialty specialty) => Create(specialty);

        public void DeleteSpecialty(Specialty specialty) => Delete(specialty);

        public async Task<IEnumerable<Specialty>> FindAllSpecialty(bool trackChanges) =>
            await FindAll(trackChanges)
                    .ToListAsync();
    }
}
