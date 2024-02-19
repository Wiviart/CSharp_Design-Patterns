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
