using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Review.App.Infrastructure;
using ReviewForum.Contract;

namespace Review.Data
{
    public class ReviewManagementContext : DbContext, IReviewManagementContext
    {
        public virtual DbSet<Thing> Things { get; set; }

        public ReviewManagementContext(DbContextOptions<ReviewManagementContext> options)
            : base(options)
        {
        }

        public virtual IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }
    }
}
