namespace ReviewManagement.Domain.Entities
{
    public class RatableEntity : AuditableEntity
    {
        public int UserId { get; set; }

        public UserInfo User { get; set; }

        public float Rate { get; set; }
    }
}