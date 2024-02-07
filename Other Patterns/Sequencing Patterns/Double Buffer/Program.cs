public class Program
{
    public static async Task Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Use double buffer? (y/n)");
        string input = Console.ReadLine();

        await Update(input == "y" ? true : false);
    }

    static async Task Update(bool useDoubleBuffer)
    {
        BufferGetter bufferGetter = new BufferGetter(useDoubleBuffer);
        while (true)
        {
            bufferGetter.Draw();
            await Task.Delay(100);
        }
    }
}