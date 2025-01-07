using Command;

internal class ACOnCommand : ICommand
{
    private readonly AC ac;

    public ACOnCommand(AC ac)
    {
        this.ac = ac;
    }

    public void Execute() => ac.On();

    public void Undo() => ac.Off();
}