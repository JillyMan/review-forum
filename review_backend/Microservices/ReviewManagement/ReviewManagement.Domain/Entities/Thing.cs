using System.Collections.Generic;

namespace ReviewForum.Contract
{
    public class Thing : BaseEntity
    {
        public float Rate { get; set; }

        public string Type { get; set; }
        
        public string Description { get; set; }

        private List<Comment> Comments { get; set; }
    }
}
