using MediatR;
using ReviewManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewManagement.App.Queries.GetCommentByThingId
{
    public class Query : IRequest<Thing>
    {
        public int ThingId { get; set; }
    }
}
