using MediatR;
using ReviewManagement.App.Commands.Place.Dto;
using ReviewManagement.App.Models;
using System;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Place.Update
{
    public class CommandUpdatePlace : IRequest<Domain.Entities.Place>, IUpdateCommand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ImageDto Image { get; set; }

        public int? CategoryId { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ICollection<DishDto> Dishes { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }
    }
}
