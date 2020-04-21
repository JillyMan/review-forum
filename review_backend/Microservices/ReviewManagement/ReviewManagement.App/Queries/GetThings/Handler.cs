using MediatR;
using ReviewManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetThings
{
    public class Handler : IRequestHandler<Query, IEnumerable<Thing>>
    {
        public Handler()
        {

        }

        public Task<IEnumerable<Thing>> Handle(Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
