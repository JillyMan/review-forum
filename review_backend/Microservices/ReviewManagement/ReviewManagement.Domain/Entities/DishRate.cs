namespace ReviewManagement.Domain.Entities
{
	public class DishRate : RatableEntity
    {
        public int DishId { get; set; }

        public Dish Dish { get; set; }
    }
}