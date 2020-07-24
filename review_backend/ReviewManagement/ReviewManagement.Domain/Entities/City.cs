namespace ReviewManagement.Domain.Entities
{
	public class City : BaseEntity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}