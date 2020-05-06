using MediatR;
using ReviewManagement.App.Commands.Place.Create.Dto;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Place.Create
{
    public class CommandCreatePlace : IRequest<Domain.Entities.Place>
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public AddressDto Address { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }

        public ICollection<DishDto> Dishes { get; set; }
    }
}
