namespace _06.FindViolations.Task8
{
    public class InstagramManager : IPostCreator, IPostInteractor, ISocialMediaAnalyser
    {
        public void CreatePost(string content)
        {
            Console.WriteLine($"Instagram Post Created: {content}");
        }
        public void LikePost(int postId)
        {
            Console.WriteLine($"Liked Instagram Post ID: {postId}");
        }
        public void CommentOnPost(int postId, string comment)
        {
            Console.WriteLine($"Commented on Instagram Post ID {postId}: {comment}");
        }
        public void AnalyzePerformance(int postId)
        {
            Console.WriteLine($"Analyzing Instagram Post Performance for ID: {postId} ");
        }
    }
}
