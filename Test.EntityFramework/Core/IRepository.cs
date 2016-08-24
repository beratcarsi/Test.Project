using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Test.EntityFramework.Core
{
    public interface IRepository<TEntity, in TId> where TEntity : Entity<TId>
    {
        IQueryable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(TId id);

        void Update(TEntity entity);

        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void ExecuteSqlQuery<TResult>(string sql);
        void Commit();
    }
}