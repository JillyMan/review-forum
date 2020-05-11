using ReviewManagement.Api.Models.Dto;
using System.Collections.Generic;

namespace ReviewManagement.Api.Models.Create
{
    public class PlaceCreateModel
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        
        public ImageDto Image { get; set; }

        public AddressDto Address { get; set; }

        public ICollection<DishDto> Dishes { get; set; }

        public ICollection<HeaderImageDto> HeaderImages { get; set; }
    }
}
