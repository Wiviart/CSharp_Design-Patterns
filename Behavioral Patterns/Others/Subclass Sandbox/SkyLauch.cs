public class SkyLaunch : Superpower
{
    public override void Activate()
    {
        Random random = new Random();
        int x = random.Next(0, 10);
        if (x < 3)
        {
            // On the ground, so spring into the air.
            PlaySound(SoundId.SOUND_SPROING, 1);
            SpawnParticles(ParticleType.PARTICLE_DUST, 10);
            Move(0, 0, 20);
        }
        else if (x > 7)
        {
            // Near the ground, so do a double jump.
            PlaySound(SoundId.SOUND_SWOOP, 1);
            Move(0, 0, -20);
        }
        else
        {
            // Way up in the air, so do a dive attack.
            PlaySound(SoundId.SOUND_DIVE, 2);
            SpawnParticles(ParticleType.PARTICLE_SPARKLES, 1);
            Move(0, 0, 0);
        }

        Console.WriteLine();
    }
}
