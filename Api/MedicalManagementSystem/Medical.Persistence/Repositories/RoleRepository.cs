using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateRole(Role role) => Create(role);

        public void DeleteRole(Role role) => Delete(role);

        public async Task<IEnumerable<Role>> FindAllRoles(bool trackChanges) =>
            await FindAll(trackChanges)
                    .ToListAsync();
    }
}
