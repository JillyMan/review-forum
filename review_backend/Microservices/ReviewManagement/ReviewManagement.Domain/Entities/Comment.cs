namespace ReviewForum.Contract
{
    public class Comment : BaseEntity
    {
        public User User { get; set; }

        public string Text { get; set; }

        public Comment SubComment { get; set; }
    }
}
