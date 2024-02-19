MazeGame game = new MazeGame();
MazeBuilder builder = new StandardMazeBuilder();

Maze maze = game.CreateMaze(builder);

maze.Enter();
