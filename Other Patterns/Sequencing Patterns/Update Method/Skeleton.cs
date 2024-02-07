class Skeleton : Entity
{
    private bool patrollingLeft_ = false;

    public Skeleton() : base()
    {
        patrollingLeft_ = false;
    }

    public override void Update(int i)
    {
        if (patrollingLeft_)
        {
            X -= i;
            if (X == 0)
            {
                patrollingLeft_ = false;
            }
        }
        else
        {
            X += i;
            if (X == 100)
            {
                patrollingLeft_ = true;
            }
        }

        Console.WriteLine("Skeleton at position " + X);
    }
}