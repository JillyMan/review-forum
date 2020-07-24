using Microsoft.AspNetCore.Mvc;
using ReviewManagement.App.Queries.Country.Get;
using ReviewManagement.App.Queries.Country.GetAll;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[Route("api/country")]
	public class CountryController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var list = await Mediator.Send(new QueryGetAllCountry());
			return Ok(list);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get([FromRoute]int id)
		{
			var country = await Mediator.Send(new QueryGetCountry() { Id = id });
			return Ok(country);
		}
	}
}
