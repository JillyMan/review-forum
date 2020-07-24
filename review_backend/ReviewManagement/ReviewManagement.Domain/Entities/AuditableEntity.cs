using System;

namespace ReviewManagement.Domain.Entities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public int CreatedById { get; set; }

        public UserInfo CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}