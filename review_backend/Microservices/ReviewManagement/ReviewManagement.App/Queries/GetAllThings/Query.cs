using MediatR;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ReviewManagement.App.Queries.GetAllThings
{
    public class Query : IRequest<IEnumerable<Thing>>
    {
    }
}
