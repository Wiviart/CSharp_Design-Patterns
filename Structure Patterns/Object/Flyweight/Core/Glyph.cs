public abstract class Glyph
{
    public abstract void Draw(Window window, GlyphContext context);
    public abstract void SetFont(Font font, GlyphContext context);
    public abstract Font GetFont(GlyphContext context);
    public abstract void Next(GlyphContext context);
}