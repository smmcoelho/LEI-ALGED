public class Program
{
    static void PrintQueueDetails<T>(Stack<T> queue)
    {
        Console.WriteLine("Queue Details:");
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        var actionsStack = new Stack<string>();
        var element1 = "Write";

        actionsStack.Push(element1);
        PrintQueueDetails(actionsStack);

        actionsStack.Push("Draw");
        PrintQueueDetails(actionsStack);

        Console.WriteLine($"Dequeue: {actionsStack.Pop()}");
        PrintQueueDetails(actionsStack);
    }
}

