using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Test.EntityFramework.Core
{
    public interface IDataService<TEntity, in TId> where TEntity : Entity<TId>
    {
        void Save<T>(T model);
        void Update<T>(T model);
        void Delete<T>(TId id);
        TModel Get<TModel>(TId id);
        IList<TModel> GetAll<TModel>();
        IList<TModel> GetAll<TModel>(Expression<Func<TEntity, bool>> predicate);
    }
}