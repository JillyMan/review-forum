using System.Collections.Generic;
using ReviewManagement.Api.Models.Dto;

namespace ReviewManagement.Api.Models.Update
{
    public class PlaceUpdateModel
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
