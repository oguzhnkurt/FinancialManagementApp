using FinancialManagement.Core.RepositoryInterfaces;
using FinancialManagement.Core.UnitOfWork;
using FinancialManagement.Infrastructure.DbContexts;
using FinancialManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialManagement.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinancialManagementDbContext _context;
        private readonly Dictionary<string, object> _repositories;

        public UnitOfWork(FinancialManagementDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<string, object>();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repository = new Repository<T>(_context);
                _repositories.Add(type, repository);
            }

            return (IRepository<T>)_repositories[type];
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
