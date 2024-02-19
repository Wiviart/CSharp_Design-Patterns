class MazeFactory
{
    public MazeFactory() { }
    public virtual Maze MakeMaze() => new Maze();
    public virtual Wall MakeWall() => new Wall();
    public virtual Room MakeRoom(int n) => new Room();
    public virtual Door MakeDoor(Room r1, Room r2) => new Door();
}