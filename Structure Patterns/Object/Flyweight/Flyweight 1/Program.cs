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
