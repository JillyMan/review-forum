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
            _memoryCache.TryGetValue<TEntity>($"{EntityName}_{id}", out var thing);
            return thing;
        }

        public void Set(TEntity thing)
        {
            _memoryCache.Set($"{EntityName}", thing);
        }
    }
}
