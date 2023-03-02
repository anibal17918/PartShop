using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Entities;
using PartShop.Domain.Repositories;

namespace PartShop.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected PartShopDbContext Context { get; }

        protected BaseRepository(PartShopDbContext context)
        {
            Context = context;
        }

        public Task<T> Find(Expression<Func<T, bool>> predicate) => Context.Set<T>().FirstOrDefaultAsync(predicate);

        public Task<List<T>> FindAll(Expression<Func<T, bool>> predicate) => Context.Set<T>().Where(predicate).ToListAsync();

        public Task<List<T>> GetAll() => Context.Set<T>().ToListAsync();

        public async Task<bool> Save(T entity)
        {
            var trackedEntity = Context.Set<T>().Attach(entity);

            if (trackedEntity.State == EntityState.Added)
            {
                entity.FechaRegistro = DateTime.Now;

                await Context.Set<T>().AddAsync(entity);
            }
            else
            {
                Context.Set<T>().Update(entity);
            }

            return await Context.SaveChangesAsync() > 1;
        }

        public async Task<bool> Delete(Expression<Func<T, bool>> predicate)
        {
            T entityToRemove = await Find(predicate);

            Context.Set<T>().Remove(entityToRemove);

            return await Context.SaveChangesAsync() > 1;
        }
    }
}
