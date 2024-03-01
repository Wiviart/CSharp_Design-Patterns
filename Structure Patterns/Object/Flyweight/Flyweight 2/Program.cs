using System.Diagnostics;

class Program
{
    static void Main()
    {
        FlyweightFactory factory = new FlyweightFactory();
        int call = 100000;

        // Get shared Flyweight each time called
        int memoryUsed2 = FlyweightCall(factory, call, true);

        // Get new Flyweight each time called
        int memoryUsed1 = FlyweightCall(factory, call, false);

        Console.WriteLine($"Memory used when not shared = {memoryUsed1} while Memory used when shared = {memoryUsed2} bytes");
    }

    static int FlyweightCall(FlyweightFactory factory, int call, bool isShared)
    {
        GC.Collect();
        GC.WaitForFullGCComplete();

        int totalMemoryBefore = (int)GC.GetTotalMemory(true);

        // Stopwatch stopwatch = new Stopwatch();
        // stopwatch.Start();
        for (int i = 0; i < call; i++)
        {
            Flyweight flyweight;
            if (i % 1000 == 0)
            {
                flyweight = factory.GetUnsharedFlyweight(i / 5);
            }
            else
            {
                if (isShared)
                    flyweight = factory.GetFlyweight("i");
                else
                    flyweight = factory.GetFlyweight(i.ToString());
            }
            flyweight.Operation(i);
        }
        // stopwatch.Stop();

        int totalMemoryAfter = (int)GC.GetTotalMemory(true);
        int memoryUsed = totalMemoryAfter - totalMemoryBefore;
        return memoryUsed;
    }
}
