using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Services;
using ReviewManagement.App.Models.Place;
using ReviewManagement.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [Route("api/places")]
    public class PlaceController : BaseController
    {
        private EntityServiceCache<PlaceModel> _cacheService;

        public PlaceController(EntityServiceCache<PlaceModel> cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Mediator.Send(new App.Queries.GetAllPlaces.Query());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute][Required]int id)
        {
            var result = _cacheService.Get(id);
            if (result == null)
            {
                result = await Mediator.Send(new App.Queries.GetPlace.Query() { PlaceId = id });
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