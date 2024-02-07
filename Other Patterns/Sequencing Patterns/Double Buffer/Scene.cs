using System;

public class Scene
{
    // The scene using Double Buffer.
    private FrameBuffer[] buffers = new FrameBuffer[2];
    private FrameBuffer current;
    private FrameBuffer next;
    int index = 0;

    public Scene()
    {
        buffers[0] = new FrameBuffer();
        current = buffers[0];
        buffers[1] = new FrameBuffer();
        next = buffers[1];

        buffer = new FrameBuffer();
    }

    public void DoubleBufferDraw()
    {
        IndexReset();

        next.Clear();

        DrawBuffer(next, current, next.Height, next.Width, true);
        DrawBuffer(next, current, next.Width, next.Height, false);

        index++;

        Swap();
    }

    void DrawBuffer(
        FrameBuffer buffer, FrameBuffer display,
        int height, int width, bool row)
    {
        if (index < height)
        {
            for (int i = 0; i < width; i++)
            {
                if (row)
                    buffer.Draw(i, index);
                else
                    buffer.Draw(index, i);

                /*  Display the buffer while drawing to show the error 
                    between the old and new version of the Scene class.*/
                Random random = new Random();

                if (random.Next(0, 10) < 5)
                {
                    DisplayBuffer(display);
                }
            }
        }
    }

    private void Swap()
    {
        FrameBuffer temp = current;
        current = next;
        next = temp;
    }

    void IndexReset()
    {
        int max = Math.Max(next.Width, next.Height);
        if (index >= max)
            index = 0;
    }

    void DisplayBuffer(FrameBuffer buffer)
    {
        string text = buffer.DisplayBuffer();
        Console.WriteLine(text);
    }


    //  This is the old version of the Scene class.
    /*  The problem is GetBuffer() can be called
        at any time, such as in the middle of Draw(). 
        So, the image is rendered is not what is expected. */

    FrameBuffer buffer = new FrameBuffer();
    public void Draw()
    {
        IndexReset();

        buffer.Clear();

        DrawBuffer(buffer, buffer, buffer.Height, buffer.Width, true);
        DrawBuffer(buffer, buffer, buffer.Width, buffer.Height, false);

        index++;
    }

}
