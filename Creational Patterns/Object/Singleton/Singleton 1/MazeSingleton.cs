class MazeSingleton : Singleton<MazeSingleton>
{
    public void Enter()
    {
        Console.WriteLine("Entering maze with singleton...");
    }
}