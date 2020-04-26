using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Diagnostics;
using System.Reflection;

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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    modelBuilder.HasAnnotation("ProductVersion", FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion);
        //    modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        //}
    }
}
