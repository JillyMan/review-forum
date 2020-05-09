using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
	public class Country : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}