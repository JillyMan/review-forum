using ReviewManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ReviewManagement.Domain.Entities.Security;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Infrastructure
{
    public interface IReviewManagementContext
    {
        DbSet<Place> Places { get; set; }

        DbSet<Comment> Comments { get; set; }

        DbSet<Category> Categories { get; set; }

        DbSet<PlaceRate> PlaceRateInfos { get; set; }

        DbSet<DishRate> DishRateInfos { get; set; }
        
        DbSet<UserInfo> Users { get; set; }

        DbSet<Address> Addresses { get; set; }

        DbSet<Country> Countries { get; set; }

        DbSet<City> Cities { get; set; }

        DbSet<Image> Images { get; set; }

        DbSet<Dish> Dishes { get; set; }

        DbSet<HeaderPlaceImage> HeaderPlaceImages { get; set; }

        DbSet<TQuery> Set<TQuery>()
            where TQuery : class;

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        IDbContextTransaction BeginTransaction();
    }
}
