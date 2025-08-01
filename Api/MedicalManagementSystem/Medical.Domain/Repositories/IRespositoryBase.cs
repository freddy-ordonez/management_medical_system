using System.Linq.Expressions;

namespace Medical.Domain.Repositories
{
    public interface IRespositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FinByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create();
        void Update();
        void Delete();

    }
}
