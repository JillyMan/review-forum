using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
using ReviewManagement.App.Commands.Category.Create;
using ReviewManagement.App.Commands.Category.Update;
using ReviewManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[ApiController]
	[Route("/api/category")]
	public class CategoryApiController : BaseController
	{
		[HttpPost]
		[Authorize(Roles = RoleNames.Admin)]
		public async Task<IActionResult> PostCategory([FromBody]CreateCategoryModel model)
		{
			var command = Mapper.Map<CommandCreateCategory>(model);
			var result = await Mediator.Send(command);
			return Ok(result.Id);
		}

		[HttpPatch]
		[Route("{id}")]
		[Authorize(Roles = RoleNames.Admin)]
		public async Task<IActionResult> PatchCategory([FromBody]UpdateCategoryModel model, [FromRoute][Required]int id)
		{
			var command = Mapper.Map<CommandCategoryUpdate>(model);
			command.Id = id;

			var result = await Mediator.Send(command);
			return Ok(result.Id);
		}
	}
}
