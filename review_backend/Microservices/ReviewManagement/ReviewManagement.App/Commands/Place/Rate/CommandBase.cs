using MediatR;
using ReviewManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewManagement.App.Commands.Place.Rate
{
    public class CommandRateBase<TResponse> : IRequest<TResponse>
        where TResponse : RatableEntity
    {
        public int UserId { get; set; }

        public float Rate { get; set; }
    }
}
