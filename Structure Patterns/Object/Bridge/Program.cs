class Program
{
    static void Main()
    {
        // Create PM Window and draw a rectangle
        var pmWindowImp = new PMWindowImp();
        var pmWindow = new PMWindow(pmWindowImp);
        Point point1 = new Point(new Coord(0), new Coord(0));
        Point point2 = new Point(new Coord(5), new Coord(5));
        pmWindow.DrawRect(point1, point2);

        // Create X Window and draw a rectangle
        var xWindowImp = new XWindowImp();
        var xWindow = new XWindow(xWindowImp);
        Point point3 = new Point(new Coord(1), new Coord(2));
        Point point4 = new Point(new Coord(4), new Coord(6));
        xWindow.DrawRect(point3, point4);
    }
}