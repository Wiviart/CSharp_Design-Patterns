public class BorderDecorator : Decorator
{
    private int _width;

    public BorderDecorator(VisualComponent component, int borderWidth) : base(component)
    {
        _width = borderWidth;
    }

    public override void Draw()
    {
        Console.WriteLine("BorderDecorator Draw()");
        base.Draw();
        DrawBorder(_width);
    }

    private void DrawBorder(int width)
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}