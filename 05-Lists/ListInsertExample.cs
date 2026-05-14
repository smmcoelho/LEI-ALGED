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
    static void Print<T>(List<T> numbers)
    {
        // print list
        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        // instantiate and initialize list
        var employees = new List<Person>
        {
            new Person("Robert", "Plant"),
            new Person("Chris", "Cornell"),
            new Person("Kurt", "Cobain"),
        };

        //show the list
        Print(employees);

        var newEmployee = new Person("Freddie", "Mercury");
        // insert at index 1
        employees.Insert(1, newEmployee);

        // insert at the end
        employees.Add(new Person("Eddie", "Vedder"));

        //show the list
        Print(employees);
    }
}
