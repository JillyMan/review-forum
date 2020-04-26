using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsApiController : BaseController
    {
        private readonly IMediator _mediator;

        public CommentsApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> PostComment([FromBody]object obj)
        {
            throw new NotImplementedException();
            var result = await _mediator.Send(new App.Commands.Thing.AddComment.Command() { });
            return Ok(result);
        }

        [HttpPost]
        public Task PatchComment()
        {
            throw new NotImplementedException();
        }
    }
}
