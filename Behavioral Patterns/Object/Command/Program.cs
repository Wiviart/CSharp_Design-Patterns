class Program
{
    static void Main()
    {
        Application app = new Application();
        Document doc = new Document();

        CommandHistory history = new CommandHistory();
        Command open = new OpenCommand(app, doc);
        Command paste = new PasteCommand(doc);

        history.ExecuteCommand(open);
        history.ExecuteCommand(paste);
        history.Undo();
        history.Undo();
    }
}