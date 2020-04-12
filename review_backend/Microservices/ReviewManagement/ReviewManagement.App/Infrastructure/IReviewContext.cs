using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ReviewForum.Contract;
using System.Threading;
using System.Threading.Tasks;

namespace Review.App.Infrastructure
{
    public interface IReviewManagementContext
    {
        public DbSet<Thing> Things { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        IDbContextTransaction BeginTransaction();
    }
}
