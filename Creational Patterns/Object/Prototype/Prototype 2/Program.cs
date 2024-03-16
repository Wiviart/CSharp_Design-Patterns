MazeGame mazeGame = new MazeGame();

Maze maze = new Maze();
Room room = new Room();
Door door = new Door();
Wall wall = new Wall();

Maze aMaze = mazeGame.CreateMaze(maze, room, door, wall);
aMaze.Enter();
