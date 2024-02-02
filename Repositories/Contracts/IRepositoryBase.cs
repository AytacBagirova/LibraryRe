using Entities.Constract;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        void CreateAsync(T entity, CancellationToken cancellationToken = default);

        IQueryable<T> GetAll();

    }
}
