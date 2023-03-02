using System.Linq.Expressions;
using PartShop.Domain.Entities;

namespace PartShop.Domain.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Find(Expression<Func<T, bool>>  predicate);
        Task<List<T>> FindAll(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAll();
        Task<bool> Save(T entity);
        Task<bool> Delete(Expression<Func<T, bool>> predicate);
    }
}
