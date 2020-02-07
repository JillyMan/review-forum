using System.Threading.Tasks;
using System.Collections.Generic;
using ReviewForum.Contract;
using ReviewForum.Core.DataAccess.Interfaces;
using MongoDB.Driver;
using ReviewForum.Core.Settings;

namespace ReviewForum.Core.DataAccess.Repositories
{
    public class ThingItemRepository : IRepository<ThingItem>
    {
        private readonly IMongoCollection<ThingItem> _collection;

        public ThingItemRepository(IMongoContext context)
        {
            _collection = context.GetCollection<ThingItem>(CollectionsEnum.Things);
        }

        public Task<List<ThingItem>> GetAll()
        {
            return _collection.Find(t => true).ToListAsync();
        }
    }
}