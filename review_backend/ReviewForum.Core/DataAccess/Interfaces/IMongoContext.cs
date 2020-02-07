using MongoDB.Driver;
using ReviewForum.Core.Settings;

namespace ReviewForum.Core.DataAccess.Interfaces
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>(CollectionsEnum collection);
    }
}