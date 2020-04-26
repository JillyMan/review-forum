using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
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
        public async Task<IActionResult> PatchThing([FromBody]ThingUpdateModel model)
        {
            var thing = await Mediator.Send(Mapper.Map<App.Commands.Thing.UpdateThing.Command>(model));
            return Ok(thing);
        }

        public async Task<IActionResult> PostAddRate([FromBody]RateCreateModel)
        {

        }
    }
}