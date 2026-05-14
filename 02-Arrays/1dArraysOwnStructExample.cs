public readonly struct Coordinates
{
    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}

public class Program
{
    static void PrintQueueDetails<T>(Stack<T> queue)
    {
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        Coordinates[] coordinates = [new(1,2), new(3, 4)];

        foreach (var c in coordinates)
        {
            Console.WriteLine(c); // for not insert new line each time:  Console.Write(number);
        }
    }
}

