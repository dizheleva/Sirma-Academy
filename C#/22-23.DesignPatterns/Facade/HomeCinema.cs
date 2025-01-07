
public class HomeCinema
{
    private DVDPlayer dvdPlayer;
    private Projector projector;
    private SoundSystem soundSystem;
    private Lights lights;

    public HomeCinema(DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem, Lights lights)
    {
        this.dvdPlayer = dvdPlayer;
        this.projector = projector;
        this.soundSystem = soundSystem;
        this.lights = lights;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine($"Preparing a movie...");
        lights.Dim(50);
        projector.On();
        projector.SetWideScreenMode();
        soundSystem.On();
        soundSystem.SetSurroundSound();
        soundSystem.SetVolume(50);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
        Console.WriteLine($"Enjoy the movie!");
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home cinema...");
        dvdPlayer.Off();
        projector.Off();
        soundSystem.Off();
        lights.TurnOff();
        Console.WriteLine("Goodbye!");
    }
}