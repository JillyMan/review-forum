using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("/api/things")]
    public class ThingsApiController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> PostThing([FromBody]ThingCreateModel model)
        {
            var thing = await Mediator.Send(Mapper.Map<App.Commands.Thing.AddThing.Command>(model));
            return Ok(thing);
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> PatchThing([FromBody]ThingUpdateModel model, [FromRoute][Required]int id)
        {
            var command = Mapper.Map<App.Commands.Thing.UpdateThing.Command>(model);
            command.ThingId = id;

            var thing = await Mediator.Send(command);
            return Ok(thing);
        }

        [HttpPost]
        [Route("{id}/rate")]
        public async Task<IActionResult> PostAddRate([FromBody]RateCreateModel rateModel, [FromRoute][Required]int id)
        {
            return null;
        }

        [HttpPost]
        [Route("{id}/comment")]
        public async Task<IActionResult> PostComment([FromBody]CommentCreateModel rateModel, [FromRoute][Required]int id)
        {
            return null;
        }
    }
}