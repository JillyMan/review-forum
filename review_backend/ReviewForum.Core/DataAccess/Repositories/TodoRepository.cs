using System.Threading.Tasks;
using System.Collections.Generic;
using ReviewForum.Contract;
using ReviewForum.Core.DataAccess.Interfaces;
using MongoDB.Driver;

namespace ReviewForum.Core.DataAccess.Repositories
{
    public class TodoRepository : IRepository<TodoItem>
    {
        private readonly IMongoCollection<TodoItem> _collection;

        public TodoRepository(IMongoContext context)
        {
            _collection = context.GetCollection<TodoItem>("Todo");
        }

        public Task<List<TodoItem>> GetAll()
        {
            return _collection.Find(t => true).ToListAsync();
        }
    }
}