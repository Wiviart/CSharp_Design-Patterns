public enum SoundId
{
    SOUND_SPROING,
    SOUND_SWOOP,
    SOUND_DIVE
}

public enum ParticleType
{
    PARTICLE_DUST,
    PARTICLE_SPARKLES,
}

public abstract class Superpower
{
    public abstract void Activate(); // Equivalent to a pure virtual function in C++

    protected void Move(int x, int y, int z)
    {
        Console.WriteLine("Move: x={0}, y={1}, z={2}", x, y, z);
        // Code here...
    }

    protected void PlaySound(SoundId sound, int volume)
    {
        Console.WriteLine("PlaySound: sound={0}, volume={1}", sound, volume);
        // Code here...}
    }
    protected void SpawnParticles(ParticleType type, int count)
    {
        Console.WriteLine("SpawnParticles: type={0}, count={1}", type, count);
        // Code here...
    }
}
