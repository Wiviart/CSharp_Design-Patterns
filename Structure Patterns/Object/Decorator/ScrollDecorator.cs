public class ScrollDecorator : Decorator
{
    public ScrollDecorator(VisualComponent component) : base(component) { }

    public override void Draw()
    {
        Console.WriteLine("ScrollDecorator Draw()");
        base.Draw();
    }
}