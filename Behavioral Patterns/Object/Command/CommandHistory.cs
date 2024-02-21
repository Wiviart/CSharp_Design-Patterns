class CommandHistory
{
    Stack<Command> history = new Stack<Command>();

    public void ExecuteCommand(Command command)
    {
        history.Push(command);
        command.Execute();
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            Command command = history.Pop();
            command.Undo();
        }
        else
        {
            Console.WriteLine("No more commands to undo");
        }
    }
}