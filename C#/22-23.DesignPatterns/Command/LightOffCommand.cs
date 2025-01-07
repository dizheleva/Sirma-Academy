using Command;

public class LightOffCommand : ICommand
{
    private readonly Light livingRoomLight;

    public LightOffCommand(Light livingRoomLight)
    {
        this.livingRoomLight = livingRoomLight;
    }

    public void Execute() => livingRoomLight.Off();

    public void Undo() => livingRoomLight.On();
}