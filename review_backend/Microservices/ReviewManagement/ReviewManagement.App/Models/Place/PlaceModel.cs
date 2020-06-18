using ReviewManagement.Domain.Entities;
using System.Collections.Generic;

namespace ReviewManagement.App.Models.Place
{
	public class PlaceModel
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public float Rate { get; set; }

        public string PhoneNumber { get; set; }

        public Image Image { get; set; }

        public Category Category { get; set; }

        public AddressModel Address { get; set; }

        public ICollection<DishModel> Dishes { get; set; }
        
        public ICollection<HeaderPlaceImageModel> HeaderImages { get; set; }
    }
}
