using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int ThingId { get; set; }

        public virtual Thing Thing { get;set;}

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public IList<int> SubCommentsId { get; set; }

        public virtual IList<Comment> SubComments { get; set; }

        public string Text { get; set; }
    }
}
