using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Entities.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.Data
{
    public class ReviewManagementContext : DbContext, IReviewManagementContext
    {
        public DbSet<Place> Places { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PlaceRate> PlaceRateInfos { get; set; }

        public DbSet<DishRate> DishRateInfos { get; set; }

        public DbSet<UserInfo> Users { get; set; }

        public DbSet<TokenInfo> Tokens { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

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
