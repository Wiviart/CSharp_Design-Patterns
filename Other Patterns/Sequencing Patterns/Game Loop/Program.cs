public static class Program
{
    public static async Task Main(string[] args)
    {
        GameManager gameManager = new GameManager();
        await gameManager.Run();
    }
}

class GameManager
{
    int frameCount = 0;
    public async Task Run()
    {
        Initialize();

        while (true)
        {
            Render();
            await Task.Delay(1000 / 60);
            frameCount++;
        }
    }

    private void Initialize()
    {
        Console.WriteLine("Initializing game...");
    }

    private void Render()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine($"[{time}] Rendering frame No.{frameCount}");
    }
}