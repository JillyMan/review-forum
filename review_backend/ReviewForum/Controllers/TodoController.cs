using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReviewForum.Contract;
using ReviewForum.Core.Services.Interfaces;

namespace ReviewForum.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet(Name = "get")]
        public async Task<List<TodoItem>> Get()
        {
            return await _todoService.GetAll();
        }
    }
}
