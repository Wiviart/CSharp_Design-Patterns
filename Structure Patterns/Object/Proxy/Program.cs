class Program
{
    static void Main()
    {
        TextDocument text = new TextDocument();
        IGraphic image = new ImageProxy("anImageFileName");
        text.Insert(image);

        text.Draw();
    }
}
