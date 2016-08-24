using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Test.EntityFramework.Core
{
    public class EntityRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        public readonly MyDatabaseContext DataContext;
        public readonly IUnitOfWork UnitOfWork;
        public readonly IDbSet<TEntity> Dbset;

        public EntityRepository(MyDatabaseContext dataContext, IUnitOfWork unitOfWork)
        {
            DataContext = dataContext;
            UnitOfWork = unitOfWork;
            Dbset = DataContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Dbset;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Dbset.Where(predicate).ToList();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate)
        {
            return Dbset.Where(predicate);
        }

        public TEntity Get(TId id)
        {
            return Dbset.Find(id);
        }

        public void Update(TEntity entity)
        {
            entity.ChangedOn = DateTime.Now;

            Dbset.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            Dbset.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> result = Dbset.Where(predicate);

            foreach (var entity in result)
            {
                Dbset.Remove(entity);
            }
        }

        public void Add(TEntity entity)
        {
            entity.CreatedOn = DateTime.Now;

            Dbset.Add(entity);
            DataContext.Entry(entity).State = EntityState.Added;
        }

        public void ExecuteSqlQuery<TResult>(string sql)
        {
            DataContext.Database.SqlQuery<TResult>(sql);
        }

        public void Commit()
        {
            UnitOfWork.Commit();
        }
    }
}