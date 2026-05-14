
class Employee
{
    public string Name { get; set; }
    public override string ToString() => $"({Name})";
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
        var employees = new List<Employee>
        {
            new Employee{Name = "John"},
            new Employee{Name = "Pete"},
            new Employee{Name = "Jay"},
            new Employee{Name = "Jane"}
        };
        // find a number
        var employeeToFind = new Employee{Name = "Pete"};
        var foundEmployee = employees.Find(n => n.Name == employeeToFind.Name);
        // this is a reference, will change the original list
        if (foundEmployee is not null)
        {
            Console.WriteLine($"{foundEmployee.Name} changed to Michael ");
            foundEmployee.Name = "Michael";
        }

        //show the list
        Print(employees);
    }
}
