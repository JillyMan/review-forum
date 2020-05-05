using System.Collections.Generic;

namespace ReviewManagement.Api.Models.Create
{
    public class PlaceCreateModel
    {
        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public ICollection<AddressDto> Addresses { get; set; }
    }
}
