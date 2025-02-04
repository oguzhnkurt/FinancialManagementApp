using FinancialManagement.Core.RepositoryInterfaces;
using System;
using System.Threading.Tasks;

namespace FinancialManagement.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
        IRepository<T> GetRepository<T>() where T : class;
    }
}
