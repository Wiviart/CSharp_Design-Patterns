abstract class Command
{
    public Command() { }
    public abstract void Execute();
    public abstract void Undo();
}