class ImageProxy : IGraphic
{
    private readonly string _fileName;
    private Image _image;

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
        _image = new Image(_fileName);
    }

    public void Draw() => _image.Draw();
    public void HandleMouse() => _image.HandleMouse();
    public void Load(StreamReader reader)
    {
        Console.WriteLine("Loading image proxy from file");
    }
    public void Save(StreamWriter writer)
    {
        Console.WriteLine("Saving image proxy to file");
    }
}