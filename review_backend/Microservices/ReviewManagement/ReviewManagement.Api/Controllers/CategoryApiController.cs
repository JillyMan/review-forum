﻿using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.Api.Models.Update;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
	[ApiController]
	[Route("/api/category")]
	public class CategoryApiController : BaseController
	{
		[HttpPost]
		public async Task<IActionResult> PostCategory([FromBody]CreateCategoryModel model)
		{
			var command = Mapper.Map<App.Commands.Category.Add.Command>(model);
			var result = await Mediator.Send(command);
			return Ok(result.Id);
		}

		[HttpPatch]
		[Route("{id}")]
		public async Task<IActionResult> PatchCategory([FromBody]UpdateCategoryModel model, [FromRoute][Required]int id)
		{
			var command = Mapper.Map<App.Commands.Category.Update.Command>(model);
			command.Id = id;

			var result = await Mediator.Send(command);
			return Ok(result.Id);
		}
	}
}