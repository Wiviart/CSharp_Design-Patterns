public class ITextView
{
    public ITextView()
    {
    }
    public void GetOrigin(out Coord x, out Coord y)
    {
        Random random = new Random();
        x = new Coord(random.Next(1, 10));
        y = new Coord(random.Next(1, 10));
    }
    public void GetExtent(out Coord width, out Coord height)
    {
        Random random = new Random();
        width = new Coord(random.Next(1, 10));
        height = new Coord(random.Next(1, 10));
    }
    public bool IsEmpty() => false;
}