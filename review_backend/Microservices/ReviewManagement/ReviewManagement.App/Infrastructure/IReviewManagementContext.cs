using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Review.App.Infrastructure
{
    public interface IReviewManagementContext
    {
        DbSet<Thing> Things { get; set; }

        DbSet<Comment> Comments { get; set; }

        DbSet<Category> Categories { get; set; }

        DbSet<ThingRateInfo> ThingRateInfos { get; set; }

        DbSet<TQuery> Set<TQuery>()
            where TQuery : class;

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        IDbContextTransaction BeginTransaction();
    }
}
