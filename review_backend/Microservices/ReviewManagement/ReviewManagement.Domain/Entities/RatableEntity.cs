namespace ReviewManagement.Domain.Entities
{
    public class RatableEntity : AuditableEntity
    {
        public float Rate { get; set; }
    }
}