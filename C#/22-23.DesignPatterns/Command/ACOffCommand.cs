using Command;

public class ACOffCommand : ICommand
{
    private readonly AC ac;

    public ACOffCommand(AC ac)
    {
        this.ac = ac;
    }

    public void Execute() => ac.Off();

    public void Undo() => ac.On();
}