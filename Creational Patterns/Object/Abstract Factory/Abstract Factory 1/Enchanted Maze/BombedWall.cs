class BombedWall : Wall
{
    public BombedWall() { }
    public override void Enter()
    {
        Console.WriteLine("BombedWall.Enter");
    }
}