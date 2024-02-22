class MazeSingleton : Singleton<MazeSingleton>
{
    public override void Enter()
    {
        Console.WriteLine("Entering maze with singleton...");
    }
}