using MediatR;
using ReviewManagement.App.Models;
using System;

namespace ReviewManagement.App.Commands.Place.UpdatePlace
{
    public class Command : IRequest<Domain.Entities.Place>, IUpdateCommand
    {
        public int PlaceId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int? CategoryId { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
