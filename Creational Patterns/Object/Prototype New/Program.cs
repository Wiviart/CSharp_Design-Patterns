MazeGame game = new MazeGame();
Room room = new Room();
Door door = new Door();
Wall wall = new Wall();
Maze maze = new Maze();

maze = game.CreateMaze(maze, room, door, wall);
maze.Enter();