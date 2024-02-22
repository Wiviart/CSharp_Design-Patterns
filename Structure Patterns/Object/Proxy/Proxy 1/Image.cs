class Image : IGraphic
{
    private string _file;

    public Image(string file) => _file = file;

    public void Draw() => Console.WriteLine($"Drawing image from file: {_file}");
    public void HandleMouse() => Console.WriteLine("Handling mouse event for image");
    public void Load(StreamReader reader) => Console.WriteLine("Loading image from file");
    public void Save(StreamWriter writer) => Console.WriteLine("Saving image to file");
}