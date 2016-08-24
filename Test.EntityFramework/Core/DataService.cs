using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FastMapper;

namespace Test.EntityFramework.Core
{
    public class DataService<TEntity, TId> : IDataService<TEntity, TId> where TEntity : Entity<TId>
    {
        private readonly IRepository<TEntity, TId> _repository;

        public DataService(IRepository<TEntity, TId> repository)
        {
            _repository = repository;
        }

        public void Save<T>(T model)
        {
            var entity = TypeAdapter.Adapt<T, TEntity>(model);

            _repository.Add(entity);
            _repository.Commit();
        }

        public void Update<T>(T model)
        {
            var entity = TypeAdapter.Adapt<T, TEntity>(model);

            _repository.Update(entity);
            _repository.Commit();
        }

        public void Delete<T>(TId id)
        {
            var entity = _repository.Get(id);

            _repository.Delete(entity);
            _repository.Commit();
        }

        public TModel Get<TModel>(TId id)
        {
            var entity = _repository.Get(id);

            return TypeAdapter.Adapt<TEntity, TModel>(entity);
        }

        public IList<TModel> GetAll<TModel>(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _repository.GetAll(predicate).AsQueryable().Project().To<TModel>().ToList();

            return entities;
        }

        public IList<TModel> GetAll<TModel>()
        {
            var entities = _repository.GetAll().AsQueryable().Project().To<TModel>().ToList();

            return entities;
        }
    }
}