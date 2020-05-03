using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Services;
using ReviewManagement.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [Route("api/things")]
    public class ThingsController : BaseController
    {
        private EntityServiceCache<Thing> _cacheService;

        public ThingsController(EntityServiceCache<Thing> cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Mediator.Send(new App.Queries.GetAllThings.Query());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute][Required]int id)
        {
            var result = _cacheService.Get(id);
            if (result == null)
            {
                result = await Mediator.Send(new App.Queries.GetThing.Query() { ThingId = id });
                _cacheService.Set(result, result.Id);
            }

            return Ok(result);
        }

        //[HttpGet]
        //[Route("{category}")]
        //public async Task<IActionResult> GetByCategory([FromRoute][Required]string categoryName)
        //{
        //    throw new NotImplementedException();
        //}
    }
}