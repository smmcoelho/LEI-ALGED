public class Program
{
    static void Print(List<int> numbers)
    {
        // print list
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("-----------------");
    }

    static void PrintAverage(List<int> numbers)
    {
        if (numbers is null || numbers.Count == 0)
        {
            Console.WriteLine("List cannot be null or empty");
            return;
        }

        Console.WriteLine($"Average: {numbers.Average()}");
        Console.WriteLine("-----------------");
    }

    public static void Main()
    {
        // instantiate and initialize list
        var numbers = new List<int> { 1, 2, 3, 4, 5};

        // add new element
        numbers.Add(6);

        Print(numbers);
        PrintAverage(numbers);

        int four = 4;
        // check if number exists in the list
        if (numbers.Contains(four))
        {
            // remove number from list
            numbers.Remove(four);
        }
        else
        {
            Console.WriteLine($"{four} not found in list");
        }

        Print(numbers);
        PrintAverage(numbers);
    }
}
