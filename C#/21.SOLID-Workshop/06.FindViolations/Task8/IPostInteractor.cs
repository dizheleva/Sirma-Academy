namespace _06.FindViolations.Task8
{
    public interface IPostInteractor
    {
        void LikePost(int postId);
        void CommentOnPost(int postId, string comment);
    }
}
