using MediatR;
using ReviewManagement.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.PostComment
{
    public class Handler : IRequestHandler<Query, Comment>
    {
        public Task<Comment> Handle(Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
