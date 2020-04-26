using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingsApiController : ControllerBase
    {
        [HttpPost]
        public Task PostThing()
        {
            throw new NotImplementedException();
        }

        [HttpPatch]
        public Task PatchThing([FromBody]object thingToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}