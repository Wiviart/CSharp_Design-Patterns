public abstract class Decorator : VisualComponent
{
    protected VisualComponent _component;

    public Decorator(VisualComponent component)
    {
        _component = component;
    }

    public override void Draw()
    {
        Console.WriteLine("Decorator Draw()");
        _component.Draw();
    }

    public override void Resize()
    {
        _component.Resize();
    }
}