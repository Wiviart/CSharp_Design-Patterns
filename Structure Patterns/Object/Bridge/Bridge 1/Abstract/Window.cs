class Window
{
    protected IWindowImp imp;

    public Window(IWindowImp imp)
    {
        this.imp = imp;
    }

    public virtual void DrawRect(Point p1, Point p2)
    {
        imp.DrawRectangle(p1, p2);
    }
}