using Controle.Core.BaseEntities;
using Controle.Core.RepositoryBase;
using System.Linq.Expressions;

namespace Controle.Infrastructure.Repository.Abstraction.Base;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
{
    public Task AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity , bool>>? filter)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
