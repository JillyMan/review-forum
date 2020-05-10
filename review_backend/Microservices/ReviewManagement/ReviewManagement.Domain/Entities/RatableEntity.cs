namespace ReviewManagement.Domain.Entities
{
    public class RatableEntity : AuditableEntity
    {
        public int Rate { get; set; }
    }
}