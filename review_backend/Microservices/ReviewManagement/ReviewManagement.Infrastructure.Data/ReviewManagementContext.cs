using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace Review.Data
{
    public class ReviewManagementContext : DbContext, IReviewManagementContext
    {
        public DbSet<Thing> Things { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Category> Categories { get; set; }

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
