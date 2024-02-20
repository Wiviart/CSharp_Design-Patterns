public class Font { }
public class Window { }

public abstract class Glyph
{
    public abstract void Draw(Window window, GlyphContext context);
    public abstract void SetFont(Font font, GlyphContext context);
    public abstract Font GetFont(GlyphContext context);
    public abstract void Next(GlyphContext context);
}

public class Character : Glyph
{
    private readonly char _charcode;
    public char Charcode => _charcode;

    public Character(char charcode)
    {
        _charcode = charcode;
    }

    public override void Draw(Window window, GlyphContext context)
    {
        Console.Write(_charcode);
    }

    public override void SetFont(Font font, GlyphContext context) => context.SetFont(font);

    public override Font GetFont(GlyphContext context) => context.GetFont();

    public override void Next(GlyphContext context) => context.Next();
}

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

public class GlyphContext
{
    private int _index;
    private readonly Dictionary<int, Font> _fonts = new Dictionary<int, Font>();

    public void Next(int step = 1) => _index += step;

    public int GetCurrentIndex() => _index;

    public Font? GetFont() => _fonts.TryGetValue(_index, out var font) ? font : null;

    public void SetFont(Font font) => _fonts[_index] = font;
}

public class GlyphFactory
{
    private const int NCHARCODES = 128;
    private readonly Character[] _characters = new Character[NCHARCODES];

    public Character CreateCharacter(char c) => _characters[c] ??= new Character(c);

    public Row CreateRow() => new Row();
}

class Program
{
    static void Main()
    {
        var factory = new GlyphFactory();
        var context = new GlyphContext();
        var window = new Window();
        var font = new Font();

        /* Create Rows and Characters */

        var row1 = factory.CreateRow();
        row1.Add(factory.CreateCharacter('H'));
        row1.Add(factory.CreateCharacter('e'));
        row1.Add(factory.CreateCharacter('l'));
        row1.Add(factory.CreateCharacter('l'));
        row1.Add(factory.CreateCharacter('o'));

        row1.SetFont(font, context);
        row1.Draw(window, context);

        var row2 = factory.CreateRow();
        row2.Add(factory.CreateCharacter('W'));
        row2.Add(factory.CreateCharacter('o'));
        row2.Add(factory.CreateCharacter('r'));
        row2.Add(factory.CreateCharacter('l'));
        row2.Add(factory.CreateCharacter('d'));

        row2.SetFont(font, context);
        row2.Draw(window, context);

        /* Remove Character from rows */

        row1.Remove(context, 'H');
        row1.Draw(window, context);

        row2.Remove(context, 'l');
        row2.Draw(window, context);
    }
}
