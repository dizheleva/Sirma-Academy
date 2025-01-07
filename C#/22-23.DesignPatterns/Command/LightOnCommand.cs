using Command;

public class LightOnCommand : ICommand
{
    private readonly Light livingRoomLight;

    public LightOnCommand(Light livingRoomLight)
    {
        this.livingRoomLight = livingRoomLight;
    }

    public void Execute() => livingRoomLight.On();

    public void Undo() => livingRoomLight.Off();
}