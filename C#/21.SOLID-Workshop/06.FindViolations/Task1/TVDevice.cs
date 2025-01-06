namespace _06.FindViolations.Task1
{
    public class TVDevice : IAudioPlayer, IVideoPlayer, IRadioPlayer
    {
        public void PlayAudio() => Console.WriteLine("Playing audio...");
        public void PlayRadio() => Console.WriteLine("Playing radio...");
        public void PlayVideo() => Console.WriteLine("Playing video...");
    }
}
