using System;

namespace AccessManagement.Domain.Entities
{
    public abstract class Auditable
    {
        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
