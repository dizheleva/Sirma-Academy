namespace _06.FindViolations.Task8
{
    public interface IPostScheduler
    {
        void SchedulePost(string content, DateTime scheduleTime);
    }
}
