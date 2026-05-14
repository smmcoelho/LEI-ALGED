public class Program
{
    static void PrintQueueDetails<T>(Stack<T> queue)
    {
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        string[] actions = {"Write", "Draw", "Erase"};

        var actionsStack = new Stack<string>(actions);
        var element1 = "Write";

        actionsStack.Push(element1);
        PrintQueueDetails(actionsStack);

        actionsStack.Push("Draw");
        PrintQueueDetails(actionsStack);

        while (actionsStack.Count > 0)
        {
            Console.WriteLine($"Pop: {actionsStack.Pop()}");
            PrintQueueDetails(actionsStack);
        }

        Console.WriteLine($"All pushed elements where popped");
    }
}
