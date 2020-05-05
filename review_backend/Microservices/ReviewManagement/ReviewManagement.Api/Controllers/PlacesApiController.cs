using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Services;
using ReviewManagement.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("/api/places")]
    public class PlasesApiController : BaseController
    {
        private EntityServiceCache<Place> _cacheService;

        public PlasesApiController(EntityServiceCache<Place> cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpPost]
        public async Task<IActionResult> Postplace([FromBody]PlaceCreateModel model)
        {
            var place = await Mediator.Send(Mapper.Map<App.Commands.Place.AddPlace.Command>(model));
            _cacheService.Set(place, place.Id);

            return Ok(place);
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> Patchplace([FromBody]PlaceUpdateModel model, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Place.UpdatePlace.Command>(model);
            command.PlaceId = id;

            var place = await Mediator.Send(command);
            _cacheService.Set(place, place.Id);

            return Ok(place);
        }

        [HttpPost]
        [Route("{id}/rate_place")]
        public async Task<IActionResult> PostAddRate([FromBody]PlaceRateCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Place.Rate.CommandPlaceRate>(rateModel);
            command.PlaceId = id;

            await Mediator.Send(command);

            _cacheService.Remove(id);

            return NoContent();
        }

        [HttpPost]
        [Route("{id}/rate_place")]
        public async Task<IActionResult> PostAddRate([FromBody]DishRateCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Place.Rate.CommandDishRate>(rateModel);
            command.DishId = id;

            await Mediator.Send(command);
            _cacheService.Remove(id);

            return NoContent();
        }

        [HttpPost]
        [Route("{id}/comment")]
        public async Task<IActionResult> PostComment([FromBody]CommentCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Place.AddComment.Command>(rateModel);
            command.PlaceId = id;

            await Mediator.Send(command);
            
            _cacheService.Remove(id);
            
            return NoContent();
        }
    }
}