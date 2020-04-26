using AccessManagement.App;
using AccessManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace AccessManagement.Data
{
    public class AccessManagementContext : DbContext, IAccessManagementContext
    {
        public AccessManagementContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<UserInfo> Users { get; set; }

        public DbSet<TokenInfo> Tokens { get; set; }

        public IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }
    }
}