using ReviewManagement.Api.Models.Create.Dto;
using System.Collections.Generic;

namespace ReviewManagement.Api.Models.Create
{
    public class PlaceCreateModel
    {
        public string Name { get; set; }

        public ImageDto Image { get; set; }

        public int CategoryId { get; set; }

        public string phoneNumber { get; set; }

        public AddressDto Address { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }

        public ICollection<DishDto> Dishes { get; set; }
    }
}
