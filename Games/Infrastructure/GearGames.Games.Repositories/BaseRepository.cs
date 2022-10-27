using GearGames.Games.Data.Context;
using GearGames.Games.Domain.Core.Interfaces.Repositories;
using GearGames.Games.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GearGames.Games.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly GameDbContext db;

        public BaseRepository(GameDbContext context)
        {
            db = context;
        }

        public TEntity Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
            db.SaveChanges();
            return entities;
        }

        public IEnumerable<TEntity> AddRangeWithTransaction(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
            return entities;
        }

        public TEntity AddWithTransaction(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            return entity;
        }

        public void Commit() => db.SaveChanges();

        public void Dispose() => db.Dispose();

        public TEntity[] GetAll()
            => db.Set<TEntity>().AsNoTracking().ToArray();

        public TEntity? GetById(long id)
            => db.Set<TEntity>().AsNoTracking().FirstOrDefault(e => e.Id == id);

        public TEntity Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
            db.SaveChanges();
            return entities;
        }

        public IEnumerable<TEntity> RemoveRangeWithTransaction(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
            return entities;
        }

        public TEntity RemoveWithTransaction(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            return entity;
        }

        public void Rollback() => db.Dispose();

        public TEntity Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().UpdateRange(entities);
            db.SaveChanges();
            return entities;
        }

        public IEnumerable<TEntity> UpdateRangeWithTransaction(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().UpdateRange(entities);
            return entities;
        }

        public TEntity UpdateWithTransaction(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            return entity;
        }
    }
}
