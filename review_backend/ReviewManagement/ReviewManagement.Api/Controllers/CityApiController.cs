using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Delete;
using ReviewManagement.App.Commands.City.Create;
using ReviewManagement.App.Commands.City.Delete;
using ReviewManagement.App.Commands.City.Update;
using ReviewManagement.App.Commands.Country.Create;
using ReviewManagement.App.Commands.Country.Update;
using ReviewManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[ApiController]
	[Route("/api/city")]
	[Authorize(Roles = RoleNames.Admin)]
	public class CityApiController : BaseController
	{
		[HttpPost]
		public async Task<IActionResult> PostCity([FromBody]CityCreateModel model)
		{
			var command = Mapper.Map<CommandCreateCity>(model);
			await Mediator.Send(command);
			return Ok();
		}

		[HttpPatch("{id}")]
		public async Task<IActionResult> PatchCity([FromBody]CityCreateModel model, [FromRoute][Required]int id)
		{
			var command = Mapper.Map<CommandUpdateCity>(model);
			command.Id = id;
			await Mediator.Send(command);
			return Ok();
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCities([FromBody]DeleteMultiplyModel model)
		{
			var command = Mapper.Map<CommandDeleteMultiplyCity>(model);
			await Mediator.Send(command);
			return Ok();
		}
	}
}