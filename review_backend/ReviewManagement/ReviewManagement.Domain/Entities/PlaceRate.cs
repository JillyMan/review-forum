namespace ReviewManagement.Domain.Entities
{
	public class PlaceRate : RatableEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }
    }
}