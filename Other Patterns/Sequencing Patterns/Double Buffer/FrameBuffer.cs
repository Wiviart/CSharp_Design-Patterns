public class FrameBuffer
{
    private const int WIDTH = 32;
    public int Width => WIDTH;
    private const int HEIGHT = 18;
    public int Height => HEIGHT;
    private const char WHITE = '_';
    public char White => WHITE;
    private const char BLACK = '0';
    public char Black => BLACK;

    private char[] pixels = new char[WIDTH * HEIGHT];

    public FrameBuffer()
    {
        Clear();
    }

    public void Clear()
    {
        for (int i = 0; i < WIDTH * HEIGHT; i++)
        {
            pixels[i] = WHITE;
        }
    }

    public void Draw(int x, int y)
    {
        pixels[(WIDTH * y) + x] = BLACK;
    }

    public string DisplayBuffer()
    {
        string text = "";

        for (int j = 0; j < HEIGHT; j++)
        {
            for (int i = 0; i < WIDTH; i++)
            {
                if (i == WIDTH - 1)
                {
                    text += pixels[i + j * WIDTH] + "\n";
                }
                else
                {
                    text += pixels[i + j * WIDTH] + " ";
                }
            }
        }

        return text;
    }
}