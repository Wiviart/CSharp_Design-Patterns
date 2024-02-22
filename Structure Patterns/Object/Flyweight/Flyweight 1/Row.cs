public class Row : Glyph
{
    private readonly List<Glyph> _children = new List<Glyph>();

    public override void Draw(Window window, GlyphContext context)
    {
        foreach (var child in _children)
        {
            child.Draw(window, context);
        }

        Console.WriteLine();
    }

    public override void SetFont(Font font, GlyphContext context)
    {
        _children.ForEach(child => child.SetFont(font, context));
    }

    public override Font GetFont(GlyphContext context)
    {
        if (_children.Count > 0)
        {
            return _children[0].GetFont(context);
        }

        return null;
    }

    public override void Next(GlyphContext context) => context.Next();

    public void Add(Glyph glyph) => _children.Add(glyph);

    public void Remove(GlyphContext context)
    {
        if (_children.Count > context.GetCurrentIndex())
        {
            _children.RemoveAt(context.GetCurrentIndex());
        }
    }

    public void Remove(GlyphContext context, char c)
    {
        if (_children.Count > context.GetCurrentIndex())
        {
            foreach (var child in _children)
            {
                if (child is Character character && character.Charcode == c)
                {
                    _children.Remove(child);
                    break;
                }
            }
        }
    }
}