class Application
{
    List<Document> docs = new List<Document>();
    public void Add(Document doc)
    {
        Console.WriteLine("Document added");
        docs.Add(doc);
    }

    internal void Remove(Document doc)
    {
        Console.WriteLine("Document removed");
        docs.Remove(doc);
    }
}