namespace Test.EntityFramework.Core
{
    public interface IUnitOfWork
    {
        void Commit();
        void Dispose(bool disposing);
    }
}