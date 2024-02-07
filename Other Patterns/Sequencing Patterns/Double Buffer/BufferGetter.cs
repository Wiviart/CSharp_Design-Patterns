class BufferGetter
{
    Scene scene = new Scene();
    bool useDoubleBuffer = true;

    public BufferGetter(bool useDoubleBuffer)
    {
        this.useDoubleBuffer = useDoubleBuffer;
    }

    public void Draw()
    {
        if (useDoubleBuffer)
        {
            scene.DoubleBufferDraw();
        }
        else
        {
            scene.Draw();
        }
    }


}