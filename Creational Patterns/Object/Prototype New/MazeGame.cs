class MazeGame
{
    public Maze CreateMaze(Maze maze, Room room, Door door, Wall wall)
    {
        Maze aMaze = maze.Clone();
        Room r1 = room.Clone();
        Room r2 = room.Clone();
        Door theDoor = door.Clone();
        theDoor.Initialize(r1, r2);

        aMaze.AddRoom(r1);
        aMaze.AddRoom(r2);

        r1.SetSide(Direction.North, wall.Clone());
        r1.SetSide(Direction.East, theDoor);
        r1.SetSide(Direction.South, wall.Clone());
        r1.SetSide(Direction.West, wall.Clone());

        r2.SetSide(Direction.North, wall.Clone());
        r2.SetSide(Direction.East, wall.Clone());
        r2.SetSide(Direction.South, wall.Clone());
        r2.SetSide(Direction.West, theDoor);

        return aMaze;
    }
}