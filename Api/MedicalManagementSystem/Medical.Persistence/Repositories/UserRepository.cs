using Medical.Domain.Entities;
using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public void CreateUser(User user) => Create(user);

        public void DeleteUser(User user) => Delete(user);

        public async Task<IEnumerable<User>> FindAllUsers(bool trackChanges) =>
            await FindAll(trackChanges)
                    .ToListAsync();

        public async Task<User?> FindUserById(int id, bool trackChanges) =>
            await FindByCondition(u => u.UserID.Equals(id), trackChanges)
                    .Include(u => u.Roles)
                    .SingleOrDefaultAsync();
    }
}
