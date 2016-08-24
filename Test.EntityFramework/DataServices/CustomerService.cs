using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.DataServices
{
    public class CustomerService : ICustomerService
    {
        public void Save<T>(T model)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(int id)
        {
            throw new NotImplementedException();
        }

        public TModel Get<TModel>(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TModel> GetAll<TModel>()
        {
            throw new NotImplementedException();
        }

        public IList<TModel> GetAll<TModel>(Expression<Func<Customer, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}