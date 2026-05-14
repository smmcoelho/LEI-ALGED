
public class MyClass
{
    public MyClass(double x, double y)
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
    static void PrintQueueDetails<T>(Queue<T> queue)
    {
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        var queue = new Queue<MyClass>();
        var element1 = new MyClass(1, 2);

        queue.Enqueue(element1);
        PrintQueueDetails(queue);

        queue.Enqueue(new MyClass(3, 4));
        PrintQueueDetails(queue);

        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        PrintQueueDetails(queue);
    }
}

