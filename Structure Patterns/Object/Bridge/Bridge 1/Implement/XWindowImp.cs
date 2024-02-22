public class XWindowImp : IWindowImp
{
    public void DrawRectangle(Point p1, Point p2)
    {
        Console.WriteLine("Drawing Rectangle on X Window:");

        for (int i = 0; i < p1.Y.Value; i++)
        {
            Console.WriteLine();
        }

        for (int i = 0; i < p2.Y.Value; i++)
        {
            for (int j = 0; j < p1.X.Value; j++)
            {
                Console.Write("  ");
            }

            for (int j = 0; j < p2.X.Value; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}