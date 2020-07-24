using Microsoft.Extensions.Caching.Memory;

namespace ReviewManagement.Api.Services
{
    public class EntityServiceCache<TEntity>
    {
        private readonly IMemoryCache _memoryCache;

        private readonly string EntityName = nameof(TEntity);

        public EntityServiceCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public TEntity Get(int id)
        {
            _memoryCache.TryGetValue<TEntity>($"{EntityName.GetType().Name}_{id}", out var place);
            return place;
        }

        public void Set(TEntity entity, int id)
        {
            _memoryCache.Set($"{EntityName.GetType().Name}_{id}", entity);
        }

        public void Remove(int id)
        {
            _memoryCache.Remove($"{EntityName.GetType().Name}_{id}");
        }
    }
}
