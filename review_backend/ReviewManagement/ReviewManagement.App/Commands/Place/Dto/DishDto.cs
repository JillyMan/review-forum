namespace ReviewManagement.App.Commands.Place.Dto
{
	public class DishDto
	{
		public int? Id { get; set; }

		public int? PlaceId { get; set; }

		public string Name { get; set; }

		public float? Price { get; set; }

		public ImageDto Image { get; set; }
	}
}
