using Entities;
using Entities.Constract;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity ,new()
    {
        private readonly RepositoryContext _context;
        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
        }
        public void CreateAsync(TEntity entity,CancellationToken cancellationToken=default)
        {
            _context.Set<TEntity>().AddAsync(entity,cancellationToken);
            _context.SaveChanges();
           
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
            
        }
    }
}
