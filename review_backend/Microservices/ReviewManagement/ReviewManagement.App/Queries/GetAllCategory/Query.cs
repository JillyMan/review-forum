using MediatR;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;

namespace ReviewManagement.App.Queries.GetAllCategory
{
    public class Query : IRequest<IEnumerable<Category>>
    {
    }
}
