using MongoDB.Driver;

namespace ReviewForum.Core.DataAccess.Interfaces
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}