using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewForum.Contract;

namespace ReviewForum.Core.Services.Interfaces
{
    public interface ITodoService
    {
        Task Add(TodoItem item);

        Task Update(TodoItem item);

        Task<TodoItem> GetById(Guid id);

        Task<List<TodoItem>> GetAll();
    }
}
