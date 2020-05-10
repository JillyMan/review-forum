using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[Route("api/category")]
	public class CategoryController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await Mediator.Send(new App.Queries.GetAllCategory.QueryGetAllCountry()));
		}
	}
}