using Medical.Domain.Entities;

namespace Medical.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> FindAllUsers(bool trackChanges);
        Task<User> FindUserById(int id, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
