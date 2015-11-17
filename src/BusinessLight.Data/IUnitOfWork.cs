using System;

namespace BusinessLight.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository Repository { get; }
        void Commit();
    }
}