namespace _06.FindViolations.Task8
{
    public class FacebookManager : IPostCreator, IPostScheduler, IPostInteractor
    {
        public void CreatePost(string content)
        {
            Console.WriteLine($"Facebook Post Created: {content}");
        }
        public void SchedulePost(string content, DateTime scheduleTime)
        {
            Console.WriteLine($"Facebook Post Scheduled: {content} at {scheduleTime}");
        }
        public void LikePost(int postId)
        {
            Console.WriteLine($"Liked Facebook Post ID: {postId}");
        }
        public void CommentOnPost(int postId, string comment)
        {
            Console.WriteLine($"Commented on Facebook Post ID {postId}: {comment}");
        }
    }
}
