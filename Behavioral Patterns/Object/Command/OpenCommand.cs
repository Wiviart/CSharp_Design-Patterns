class OpenCommand : Command
{
    Application app;
    Document doc;

    public OpenCommand(Application app, Document doc) : base()
    {
        this.app = app;
        this.doc = doc;
    }

    public override void Execute()
    {
        Console.WriteLine("Open command executed");
        app.Add(doc);
        doc.Open();
    }

    public override void Undo()
    {
        Console.WriteLine("Open command undone");
        app.Remove(doc);
    }
}