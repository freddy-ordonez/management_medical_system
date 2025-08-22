using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> FindAllRoles(bool trackChanges);
        void CreateRole(Role role);
        void DeleteRole(Role role);
    }
}
