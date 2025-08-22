using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface ISpecialtyRepository
    {
        Task<IEnumerable<Specialty>> FindAllSpecialty(bool trackChanges);
        void CreateSpecialty(Specialty specialty);
        void DeleteSpecialty(Specialty specialty);
    }
}
