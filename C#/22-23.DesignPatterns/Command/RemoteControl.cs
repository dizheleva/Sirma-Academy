using Command;

public class RemoteControl
{
    private ICommand command;

    private Stack<ICommand> commandHistory = new Stack<ICommand>();

    public void SetCommand(ICommand command) => this.command = command;
    public void PressButton()
    {
        command.Execute();
        commandHistory.Push(command);
    }
    public void PressUndo()
    {
        if (commandHistory.Count > 0)
        {
            ICommand lastCommand = commandHistory.Pop();
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("No commands to undo.");
        }
    }
}