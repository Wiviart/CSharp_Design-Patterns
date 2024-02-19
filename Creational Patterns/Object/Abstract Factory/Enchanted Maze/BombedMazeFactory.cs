class BombedMazeFactory : MazeFactory
{
    public BombedMazeFactory() { }
    public override Wall MakeWall() => new BombedWall();
    public override Room MakeRoom(int n) => new RoomWithABomb(n);
}