using MediatR;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;

namespace ReviewManagement.App.Queries.GetThings
{
    public class Query : IRequest<IEnumerable<Thing>>
    {
    }
}
