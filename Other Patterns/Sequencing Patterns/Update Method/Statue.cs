class Statue : Entity
{
    int frames_ = 0;
    int delay_ = 0;
    private void ShootLightning()
    {
        Console.WriteLine("Statue shoots lightning!");
    }

    public Statue(int delay) : base()
    {
        frames_ = 0;
        delay_ = delay;
    }

    public override void Update(int i)
    {
        frames_++;
        if (frames_ == delay_)
        {
            ShootLightning();
            frames_ = 0;
        }
    }
}