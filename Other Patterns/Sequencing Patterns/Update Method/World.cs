public class World
{
    private const int MAX_ENTITIES = 100; // Assuming MAX_ENTITIES is a constant value

    private Entity[] entities_ = new Entity[MAX_ENTITIES];
    private int numEntities_;

    public World(int i)
    {
        numEntities_ = i;
    }

    public void GameLoop()
    {
        while (true)
        {
            // Handle user input...

            // Update each entity.
            for (int i = 0; i < numEntities_; i++)
            {
                if (entities_[i] == null)
                {
                    if (i % 3 == 0)
                    {
                        entities_[i] = new Statue(i);
                    }
                    else if (i % 3 == 1)
                    {
                        entities_[i] = new Skeleton();
                    }
                    else
                    {
                        entities_[i] = new Entity();
                    }
                }

                entities_[i].Update(i);
            }

            Console.WriteLine("--------------------------------------------------");
            // Physics and rendering...

            // Pause for a bit...
            System.Threading.Thread.Sleep(1000 / 60);
        }
    }
}