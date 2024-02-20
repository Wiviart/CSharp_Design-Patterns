public class Point
{
    public Coord X { get; set; }
    public Coord Y { get; set; }
    public Point(Coord x, Coord y)
    {
        X = x;
        Y = y;
    }
}