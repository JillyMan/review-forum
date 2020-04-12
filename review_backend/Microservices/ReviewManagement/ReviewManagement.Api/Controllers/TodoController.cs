using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReviewForum.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingController : ControllerBase
    {

        public ThingController()
        {
        }

        [HttpGet]
        public Task Get()
        {
            return Task.CompletedTask;
        }
    }
}
