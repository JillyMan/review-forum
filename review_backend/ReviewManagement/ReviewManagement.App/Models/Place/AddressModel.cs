using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Models.Place
{
	public class AddressModel
	{
		public int Id { get; set; }

		public City City { get; set; }

		public string Street { get; set; }

		public float Latitude { get; set; }

		public float Longitude { get; set; }
	}
}
