using Command;

internal class Program
{
    private static void Main(string[] args)
    {
        Light livingRoomLight = new Light();
        AC ac = new AC();

        ICommand lightOn = new LightOnCommand(livingRoomLight);
        ICommand lightOff = new LightOffCommand(livingRoomLight);
        ICommand acOn = new ACOnCommand(ac);
        ICommand acOff = new ACOffCommand(ac);

        RemoteControl remote = new RemoteControl();

        Console.WriteLine("Testing Light Commands:");
        remote.SetCommand(lightOn);
        remote.PressButton();
        remote.PressUndo();

        Console.WriteLine("\nTesting AC Commands:");
        remote.SetCommand(acOn);
        remote.PressButton();
        remote.PressUndo();
    }
}