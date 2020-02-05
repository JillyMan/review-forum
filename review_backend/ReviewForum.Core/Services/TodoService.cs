using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewForum.Contract;
using ReviewForum.Core.DataAccess.Interfaces;
using ReviewForum.Core.Services.Interfaces;

namespace ReviewForum.Core.Services
{
    public class TodoService : ITodoService
    {
        IRepository<TodoItem> _repository;

        public TodoService(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }

        public Task Add(TodoItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<TodoItem>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<TodoItem> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}