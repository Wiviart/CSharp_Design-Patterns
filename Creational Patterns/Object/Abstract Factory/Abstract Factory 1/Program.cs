MazeGame mazeGame = new MazeGame();
MazeFactory factory = new BombedMazeFactory();
Maze maze = mazeGame.CreateMaze(factory);
maze.Enter();