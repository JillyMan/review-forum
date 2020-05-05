using MediatR;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Place.AddPlace
{
    public class Command : IRequest<Domain.Entities.Place>
    {
        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        ICollection<AddressDto> Addresses { get; set; }
    }
}
