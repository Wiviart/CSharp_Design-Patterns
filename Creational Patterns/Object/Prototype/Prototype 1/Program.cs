Person person = new Person(20, new DateTime(1990, 1, 1), "John", new IdInfo(123456));
person.Display();

Person shallowCopy = person.ShallowCopy();
shallowCopy.Display();

Person deepCopy = person.DeepCopy();
deepCopy.Display();

Person clone = person.Clone();
clone.Display();

Console.WriteLine("\nAfter changes:");

person.Age = 30;
person.BirthDate = new DateTime(1995, 1, 1);
person.Name = "Tom";
person.IdInfo.IdNumber = 654321;

person.Display();
shallowCopy.Display();
deepCopy.Display();
clone.Display();