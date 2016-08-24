using Test.EntityFramework.Core;
using Test.EntityFramework.Entities;

namespace Test.EntityFramework.DataServices
{
    public interface ICustomerService : IDataService<Customer, int>
    {
        
    }
}