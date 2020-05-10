using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.App.Commands.Country.Create;
using ReviewManagement.App.Commands.Country.Update;
using ReviewManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[ApiController]
	[Route("/api/country")]
	public class CountryApiController : BaseController
	{
		[HttpPost]
		[Authorize(Roles = RoleNames.Admin)]
		public async Task<IActionResult> PostCountry([FromBody]CountryCreateModel model)
		{
			var command = Mapper.Map<CommandCreateCountry>(model);
			await Mediator.Send(command);
			return Ok();
		}

		[HttpPatch("{id}")]
		[Authorize(Roles = RoleNames.Admin)]
		public async Task<IActionResult> PatchCountry([FromBody]CountryCreateModel model, [FromRoute][Required]int id)
		{
			var command = Mapper.Map<CommandCountryUpdate>(model);
			command.Id = id;
			await Mediator.Send(command);
			return Ok();
		}
	}
}
