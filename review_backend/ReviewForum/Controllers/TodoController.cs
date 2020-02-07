using Microsoft.AspNetCore.Mvc;
using ReviewForum.Contract;
using ReviewForum.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReviewForum.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingController : ControllerBase
    {
        private IThingReviewService _todoService;

        public ThingController(IThingReviewService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<List<ThingItem>> Get()
        {
            return await _todoService.GetAll();
        }
    }
}
