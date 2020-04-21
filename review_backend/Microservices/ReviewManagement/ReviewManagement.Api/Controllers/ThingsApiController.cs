using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThingsApiController : ControllerBase
    {
        [HttpPost]
        [Route("/{id}/comment")]
        public Task PostComment()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/{id}/comment")]
        public Task PatchComment()
        {
            throw new NotImplementedException();
        }

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