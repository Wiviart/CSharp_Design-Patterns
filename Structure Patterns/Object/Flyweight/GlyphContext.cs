public class GlyphContext
{
    private int _index;
    private readonly Dictionary<int, Font> _fonts = new Dictionary<int, Font>();

    public void Next(int step = 1) => _index += step;

    public int GetCurrentIndex() => _index;

    public Font? GetFont() => _fonts.TryGetValue(_index, out var font) ? font : null;

    public void SetFont(Font font) => _fonts[_index] = font;
}