public class Shape
{
    public Shape() { }
    public virtual void BoundingBox(
      out Point bottomLeft, out Point topRight)
    {
        bottomLeft = new Point(0, 0);
        topRight = new Point(0, 0);
    }
    public virtual Manipulator CreateManipulator()
     => new Manipulator();
    public virtual bool IsEmpty() => false;
}