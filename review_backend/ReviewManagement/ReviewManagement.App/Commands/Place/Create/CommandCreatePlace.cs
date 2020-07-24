using MediatR;
using ReviewManagement.App.Commands.Place.Dto;
using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Place.Create
{
    public class CommandCreatePlace : IRequest<Domain.Entities.Place>, ICreateCommand
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ImageDto Image { get; set; }

        public AddressDto Address { get; set; }

        public UserInfo CreatedBy { get; set; }
        
        public ICollection<DishDto> Dishes { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }
    }
}
