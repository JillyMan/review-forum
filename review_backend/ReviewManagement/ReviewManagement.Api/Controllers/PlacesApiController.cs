using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.Api.Services;
using ReviewManagement.App.Commands.Comment.Create;
using ReviewManagement.App.Commands.Place.Create;
using ReviewManagement.App.Commands.Rate.Create;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("/api/places")]
    public class PlasesApiController : BaseController
    {
        [HttpPost]
        [Authorize(Roles = RoleNames.SuperUser)]
        public async Task<IActionResult> PostPlace([FromBody]PlaceCreateModel model)
        {
            var place = await Mediator.Send(Mapper.Map<CommandCreatePlace>(model));
            return Ok(new {place.Id});
        }

        [HttpPatch]
        [Route("{id}")]
        [Authorize(Roles = RoleNames.SuperUser)]
        public async Task<IActionResult> PatchPlace([FromBody]PlaceUpdateModel model, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Place.Update.CommandUpdatePlace>(model);
            command.Id = id;

            var place = await Mediator.Send(command);

            return NoContent();
        }

        [HttpPost]
        [Route("{id}/rate_place")]
        [Authorize(Roles = "User,Admin,SuperUser")]
        public async Task<IActionResult> PostPlaceRate([FromBody]PlaceRateCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<CommandCreatePlaceRate>(rateModel);
            command.PlaceId = id;

            await Mediator.Send(command);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/rate_dish")]
        [Authorize(Roles = "User,Admin,SuperUser")]
        public async Task<IActionResult> PostDishRate([FromBody]DishRateCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<CommandCreateDishRate>(rateModel);
            command.DishId = id;

            await Mediator.Send(command);

            return Ok();
        }

        [HttpPost]
        [Authorize]
        [Route("{id}/comment")]
        [Authorize(Roles = "User,Admin,SuperUser")]
        public async Task<IActionResult> PostComment([FromBody]CommentCreateModel rateModel, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<CommandCreateComment>(rateModel);
            command.PlaceId = id;

            await Mediator.Send(command);
            
            return Ok();
        }
    }
}