using System;
using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class EFUnitOfWork:IUnitOfWork
    {
        private BLContext db;
       // private AppContext db;
        private Repository<PersonBase> personBaseRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new BLContext(connectionString);
        }
        public IRepository<PersonBase> PersonBases
        {
            get
            {
                if (personBaseRepository == null)
                    personBaseRepository = new Repository<PersonBase>(db);
                return personBaseRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
