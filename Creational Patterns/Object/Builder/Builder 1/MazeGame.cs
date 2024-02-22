class MazeGame
{
    public Maze CreateMaze(MazeBuilder builder)
    {
        builder.BuildMaze();
        builder.BuildRoom(1);
        builder.BuildRoom(2);
        builder.BuildDoor(1, 2);
        return builder.GetMaze();
    }

    public Maze CreateComplexMaze(MazeBuilder builder)
    {
        for (int i = 0; i < 1000; i++)
        {
            builder.BuildRoom(i);
        }

        return builder.GetMaze();
    }
}