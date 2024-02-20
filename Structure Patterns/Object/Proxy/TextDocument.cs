class TextDocument
{
    private List<IGraphic> _graphics;

    public TextDocument()
    {
        _graphics = new List<IGraphic>();
    }

    public void Insert(IGraphic graphic) => _graphics.Add(graphic);

    public void Draw()
    {
        foreach (IGraphic graphic in _graphics)
        {
            graphic.Draw();
        }
    }
}