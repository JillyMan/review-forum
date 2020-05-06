namespace ReviewManagement.Domain.Entities
{
	public class HeaderImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public int PlaceId { get; set; }

        public Place Place { get; set; }
    }
}