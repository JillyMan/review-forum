using System.Collections.Generic;

namespace ReviewManagement.Api.Models.Create
{
	public class CountryCreateModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<CityCreateModel> Cities { get; set; }
	}

	public class CityCreateModel
	{
		public string Name { get; set; }

		public int? CountryId { get; set; }
	}
}
