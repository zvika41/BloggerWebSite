namespace Blog.Models.CommentsModel
{
    public class SubComment : Comment
    {
        public int MainCommentId { get; set; }
    }
}
