using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[Route("api/country")]
	public class CountryController : BaseController
	{
		[HttpGet]
		public async Task<Domain.Entities.Country> Get() 
		{
			return null;
		}

		[HttpGet("{id}")]
		public async Task<Domain.Entities.Country> Get([FromRoute]int id)
		{
			return null;
		}
	}
}
