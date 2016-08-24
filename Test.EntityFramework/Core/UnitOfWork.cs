using System;

namespace Test.EntityFramework.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private MyDatabaseContext Context { get; set; }

        public UnitOfWork(MyDatabaseContext databaseContext)
        {
            Context = databaseContext;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                    Context = null;
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}