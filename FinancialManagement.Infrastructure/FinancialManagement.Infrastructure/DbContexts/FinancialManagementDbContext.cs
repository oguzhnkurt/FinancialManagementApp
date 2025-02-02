using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.DbContexts
{
    public class FinancialManagementDbContext : DbContext
    {
        public FinancialManagementDbContext(DbContextOptions<FinancialManagementDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
