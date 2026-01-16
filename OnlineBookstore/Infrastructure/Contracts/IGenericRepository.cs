using System.Linq.Expressions;

namespace OnlineBookstore.Infrastructure.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, object>> includes = null
        );
        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, object>> includes = null);
        Task Insert(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}