namespace ReviewManagement.Api.Models.Dto
{
	public class DishDto
	{
		public int? Id { get; set; }

		public string Name { get; set; }
		
		public float Price { get; set; }

		public ImageDto Image { get; set; }
	}
}
