using MediatR;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ReviewManagement.App.Queries.GetThings
{
    public class Query : IRequest<IEnumerable<Thing>>
    {
    }
}
