

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
        var numbers = new List<int> { 1, 2, 3, 4, 5};
        // find a number
        var numberToFind = 4;
        var four = numbers.Find(n => n == numberToFind);
        // this is a copy, won't change the original list
        four = 5;
        //show the list
        Print(numbers);
     }
}
