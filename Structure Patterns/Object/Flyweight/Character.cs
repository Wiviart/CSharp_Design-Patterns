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