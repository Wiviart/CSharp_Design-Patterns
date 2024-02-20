public class Window
{
    public void SetContents(VisualComponent contents)
    {
        Console.WriteLine("Window SetContents()");
        contents.Draw();
    }
}