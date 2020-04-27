using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Review.App.Infrastructure
{
    public interface IReviewManagementContext
    {
        public DbSet<Thing> Things { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ThingRateInfo> ThingRateInfos { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        IDbContextTransaction BeginTransaction();
    }
}
