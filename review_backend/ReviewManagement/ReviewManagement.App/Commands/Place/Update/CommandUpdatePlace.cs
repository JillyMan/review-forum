using MediatR;
using ReviewManagement.App.Commands.Place.Dto;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Place.Update
{
    public class CommandUpdatePlace : IRequest<Domain.Entities.Place>
    {
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ImageDto Image { get; set; }

        public AddressDto Address { get; set; }

        public int[] RemoveDishes { get; set; }

        public ICollection<DishDto> Dishes { get; set; }

        public int[] RemoveHeaderImages { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }
    }
}
