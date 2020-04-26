﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetThings
{
    public class Handler : IRequestHandler<Query, IEnumerable<Thing>>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Thing>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Things.ToListAsync();
        }
    }
}