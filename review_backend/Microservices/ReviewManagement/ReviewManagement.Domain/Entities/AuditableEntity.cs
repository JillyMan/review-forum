using System;

namespace ReviewManagement.Domain.Entities
{
    public abstract class AuditableEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}