class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person
        (
            42,
            Convert.ToDateTime("1977-01-01"),
            "Jack Daniels",
            new IdInfo(666)
        );

        int i = 0;
        List<Person> list = new List<Person>();

        for (i = 0; i < 10; i++)
        {
            if (i % 3 == 0)
            {
                Person p = p1.ShallowCopy();
                p.Name = "ShallowCopy" + i;
                list.Add(p);
            }
            else if (i % 3 == 1)
            {
                Person p = p1.DeepCopy();
                // p.Name = "DeepCopy" + i;
                list.Add(p);
            }
            else
            {
                Person p4 = p1.Clone();
                p4.Name = "Clone" + i;
                list.Add(p4);
            }
        }

        Console.WriteLine("Element values original:");
        p1.Display();

        foreach (Person p in list)
        {
            p.Display();
        }

        p1.Age = 378;
        p1.BirthDate = Convert.ToDateTime("1970-01-01");
        p1.Name = "Friank";
        p1.IdInfo.IdNumber = 7978;
        p1.type = Person.Type.None;

        Console.WriteLine("Element values after changes to p1:");
        p1.Display();

        foreach (Person p in list)
        {
            p.Display();
        }
    }
}
