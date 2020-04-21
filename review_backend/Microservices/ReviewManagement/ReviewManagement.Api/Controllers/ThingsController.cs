using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [Route("api/[controller]")]
    public class ThingsController : ControllerBase
    {
        [HttpGet]
        [Route("/things")]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("things/{id}")]
        public async Task<IActionResult> GetById([FromRoute][Required]int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("things/{category}")]
        public async Task<IActionResult> GetByCategory([FromRoute][Required]string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}