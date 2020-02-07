using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewForum.Contract
{
    public class CommentInfo : BaseEntity
    {
        public UserInfo UserInfo { get; set; }

        public string Text { get; set; }

        public CommentInfo SubComment { get; set; }
    }
}
