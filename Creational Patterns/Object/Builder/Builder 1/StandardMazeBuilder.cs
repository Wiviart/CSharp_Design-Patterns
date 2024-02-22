class StandardMazeBuilder : MazeBuilder
{
    private Maze _currentMaze;

    public StandardMazeBuilder() : base()
    {
        _currentMaze = new Maze();
    }
    public override void BuildMaze()
    {
        if (_currentMaze == null)
        {
            _currentMaze = new Maze();
            Console.WriteLine("Building maze");
        }
        else
        {
            Console.WriteLine("Maze already built");
        }
    }
    public override void BuildRoom(int room)
    {
        if (_currentMaze.RoomNo(room) == null)
        {
            Room newRoom = new Room(room);
            _currentMaze.AddRoom(newRoom);
            newRoom.SetSide(Direction.North, new Wall());
            newRoom.SetSide(Direction.South, new Wall());
            newRoom.SetSide(Direction.East, new Wall());
            newRoom.SetSide(Direction.West, new Wall());

            Console.WriteLine($"Building room {room}");
        }
        else
        {
            Console.WriteLine($"Room {room} already built");
        }
    }
    public override void BuildDoor(int roomFrom, int roomTo)
    {
        Room r1 = _currentMaze.RoomNo(roomFrom);
        Room r2 = _currentMaze.RoomNo(roomTo);
        Door d = new Door(r1, r2);
        r1.SetSide(CommonWall(r1, r2), d);
        r2.SetSide(CommonWall(r2, r1), d);
        Console.WriteLine($"Building door between room {roomFrom} and room {roomTo}");
    }
    public override Maze GetMaze()
    {
        return _currentMaze;
    }
    private Direction CommonWall(Room room1, Room room2)
    {
        return room1.RoomNumber > room2.RoomNumber ? Direction.North : Direction.South;
    }
}