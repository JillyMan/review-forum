namespace ReviewManagement.Domain.Entities
{
	public class HeaderPlaceImage : BaseEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }
    }
}