class Maze
{
    List<Room> rooms = new List<Room>();
    public Maze() { }
    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public void Enter()
    {
        foreach (var room in rooms)
        {
            room.Enter();
        }
    }

    public Maze Clone()
    {
        Maze maze = new Maze();
        foreach (var room in rooms)
        {
            maze.AddRoom(room.Clone());
        }
        return maze;
    }
}