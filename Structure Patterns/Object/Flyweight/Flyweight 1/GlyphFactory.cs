public class GlyphFactory
{
    private const int NCHARCODES = 128;
    private readonly Character[] _characters = new Character[NCHARCODES];

    public Character CreateCharacter(char c) => _characters[c] ??= new Character(c);

    public Row CreateRow() => new Row();
}