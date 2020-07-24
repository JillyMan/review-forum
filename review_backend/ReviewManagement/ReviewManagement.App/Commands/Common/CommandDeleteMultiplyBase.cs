using MediatR;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Common
{
	public class CommandDeleteMultiplyBase : IRequest
	{
		public ICollection<int> Ids { get; set; }
	}
}
