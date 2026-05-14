public class Program
{
    static void PrintStackDetails<T>(Stack<T> queue)
    {
        Console.WriteLine("Queue Details:");
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        var actionsStack = new Stack<string>();
        var element1 = "Write";

        actionsStack.Push(element1);
        PrintStackDetails(actionsStack);

        actionsStack.Push("Draw");
        PrintStackDetails(actionsStack);

        Console.WriteLine($"Dequeue: {actionsStack.Pop()}");
        PrintStackDetails(actionsStack);
    }
}

