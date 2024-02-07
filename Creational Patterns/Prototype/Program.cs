public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public enum Type { None, ShallowCopy, DeepCopy, Clone };
    public Type type;

    public Person(int age, DateTime birthDate, string name, IdInfo idInfo, Type type = Type.None)
    {
        this.type = type;
        this.Age = age;
        this.BirthDate = birthDate;
        this.Name = name;
        this.IdInfo = idInfo;
    }

    public Person Clone()
    {
        return new Person(this.Age, this.BirthDate, this.Name, this.IdInfo, Type.Clone);
    }

    //Các object con bên trong chỉ được copy reference. Nghĩa là chỉ nhân bản được value type.
    public Person ShallowCopy()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.type = Type.ShallowCopy;
        return clone;
    }

    //Các object con bên trong cũng được copy lại toàn bộ các thuộc tính.
    public Person DeepCopy()
    {
        Person clone = (Person)this.MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = Name;
        clone.type = Type.DeepCopy;
        return clone;
    }

    public void Display()
    {
        Console.Write("\nID#: {0:d} - ", IdInfo.IdNumber);
        Console.WriteLine($"Type:{type} , Name: {Name}, Age: {Age}, BirthDate: {BirthDate}");
    }
}

public class IdInfo
{
    public int IdNumber;

    public IdInfo(int idNumber)
    {
        this.IdNumber = idNumber;
    }
}

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
