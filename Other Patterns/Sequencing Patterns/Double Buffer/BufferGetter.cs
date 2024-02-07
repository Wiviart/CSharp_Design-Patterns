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
            // You need an instance of Program to access the scene field
            scene.DoubleBufferDraw();
        }
        else
        {
            // You need an instance of Program to access the scene field
            scene.Draw();
        }
    }


}