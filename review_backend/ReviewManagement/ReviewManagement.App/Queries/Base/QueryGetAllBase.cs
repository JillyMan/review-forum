using MediatR;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;

namespace ReviewManagement.App.Queries.Base
{
	public class QueryGetAllBase<TEnity> : IRequest<IEnumerable<TEnity>>
		where TEnity : BaseEntity
	{
	}
}
