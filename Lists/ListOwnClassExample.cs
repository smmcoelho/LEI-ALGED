
public class Person
{
    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string Name { get; }
    public string Surname { get; }

    public override string ToString() => $"({Name}, {Surname})";
}

public class Program
{
    static void Print(List<Person> persons)
    {
        // print list
        foreach (var person in persons)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("-----------------");
    }
    public static void Main()
    {
        // instantiate and initialize list
        var persons = new List<Person>
        {
            new("Jimmy", "Page"),
            new("Eddie", "Van Halen")
        };

        // add new element
        persons.Add(new("Tony", "Iommi"));

        Print(persons);

        // instantiate new Person
        var brian = new Person("Brian", "May");

        // check if person exists in the list
        if (persons.Contains(brian))
        {
            // remove person from list
            persons.Remove(brian);
        }
        else
        {
            // person not found
            Console.WriteLine($"{brian} not found in list");
        }

        Print(persons);
    }
}

