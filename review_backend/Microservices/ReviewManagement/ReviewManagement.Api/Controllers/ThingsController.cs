using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [Route("api/things")]
    public class ThingsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = Mediator.Send(new App.Queries.GetAllThings.Query());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute][Required]int id)
        {
            var result = Mediator.Send(new App.Queries.GetThing.Query() { ThingId = id });
            return Ok(result);
        }

        [HttpGet]
        [Route("{category}")]
        public async Task<IActionResult> GetByCategory([FromRoute][Required]string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}