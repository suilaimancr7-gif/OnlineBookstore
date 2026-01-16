using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain.Data;
using OnlineBookstore.Infrastructure.Contracts;
using System.Linq.Expressions;

namespace OnlineBookstore.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly OnlineBookstoreContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(OnlineBookstoreContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
            if (expression != null) query = query.Where(expression);
            if (includes != null) query = includes(query);
            if (orderBy != null) query = orderBy(query);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            if (entity != null)
            {
                _db.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes != null) query = includes(query);
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }
    }
}