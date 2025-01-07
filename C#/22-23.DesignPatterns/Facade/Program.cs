internal class Program
{
    private static void Main(string[] args)
    {
        DVDPlayer dvdPlayer = new DVDPlayer();
        Projector projector = new Projector();
        SoundSystem soundSystem = new SoundSystem();
        Lights lights = new Lights();

        HomeCinema homeCinema = new HomeCinema(dvdPlayer, projector, soundSystem, lights);

        homeCinema.WatchMovie("Venom");
        homeCinema.EndMovie();
    }
}