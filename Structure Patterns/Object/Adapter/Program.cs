public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            ITextView textView = new ITextView();
            TextShape shape = new TextShape(textView);
            shape.BoundingBox(out Point bottomLeft, out Point topRight);
            shape.DrawShape();

            Thread.Sleep(1000);
        }
    }

}