class PasteCommand : Command
{
    Document? doc;

    public PasteCommand(Document doc) : base()
    {
        this.doc = doc;
    }

    public override void Execute()
    {
        Console.WriteLine("Paste command executed");

        if (doc != null)
            doc.Paste();
    }

    public override void Undo()
    {
        Console.WriteLine("Paste command undone");
    }
}