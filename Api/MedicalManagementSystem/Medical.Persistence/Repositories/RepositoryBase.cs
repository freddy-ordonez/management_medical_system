using Medical.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Medical.Persistence.Repositories
{
    public class RepositoryBase<T> : IRespositoryBase<T> where T : class
    {
        protected ApplicationContext context;

        protected RepositoryBase(ApplicationContext applicationContext)
        {
            this.context = applicationContext;
        }

        public void Create(T entity) => context.Set<T>().Add(entity);

        public void Delete(T entity) => context.Set<T>().Remove(entity);

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? 
            context.Set<T>().Where(expression).AsNoTracking() :
            context.Set<T>().Where(expression);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            context.Set<T>().AsNoTracking() :
            context.Set<T>();

        public void Update(T entity) => context.Update<T>(entity);
    }
}
