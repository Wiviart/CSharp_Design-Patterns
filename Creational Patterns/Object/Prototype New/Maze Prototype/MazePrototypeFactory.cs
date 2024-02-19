class MazePrototypeFactory : MazeFactory
{
    private Maze _prototypeMaze;
    private Wall _prototypeWall;
    private Room _prototypeRoom;
    private Door _prototypeDoor;

    public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door) : base()
    {
        _prototypeMaze = maze;
        _prototypeWall = wall;
        _prototypeRoom = room;
        _prototypeDoor = door;
    }

    public override Maze MakeMaze() => _prototypeMaze.Clone();
    public override Wall MakeWall() => _prototypeWall.Clone();
    public override Room MakeRoom(int n) => _prototypeRoom.Clone();
    public override Door MakeDoor(Room r1, Room r2)
    {
        Door door = _prototypeDoor.Clone();
        door.Initialize(r1, r2);
        return door;
    }
}