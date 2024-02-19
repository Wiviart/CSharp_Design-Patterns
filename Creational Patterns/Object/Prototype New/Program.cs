MazeGame game = new MazeGame();
Room room = new Room();
Door door = new Door();
Wall wall = new Wall();
Maze maze = new Maze();
MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(
    maze, wall, room, door);
maze = game.CreateMaze(simpleMazeFactory);
maze.Enter();