using System;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<PersonBase> PersonBases { get;}
        void Save();
    }
}
