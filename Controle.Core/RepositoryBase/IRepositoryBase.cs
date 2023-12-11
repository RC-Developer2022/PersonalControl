using Controle.Core.BaseEntities;
using System.Linq.Expressions;

namespace Controle.Core.RepositoryBase;

public interface IRepositoryBase<TEntity> where TEntity : EntityBase
{
    Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>? filter);
    Task<TEntity> GetByIdAsync(Guid id);
    Task AddAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task Update(TEntity entity)
}
