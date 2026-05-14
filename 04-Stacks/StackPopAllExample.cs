public class Program
{
    static void PrintStackDetails<T>(Stack<T> queue)
    {
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        string[] actions = {"Write", "Draw", "Erase"};

        var actionsStack = new Stack<string>(actions);
        var element1 = "Write";

        actionsStack.Push(element1);
        PrintStackDetails(actionsStack);

        actionsStack.Push("Draw");
        PrintStackDetails(actionsStack);

        while (actionsStack.Count > 0)
        {
            Console.WriteLine($"Pop: {actionsStack.Pop()}");
            PrintStackDetails(actionsStack);
        }

        Console.WriteLine($"All pushed elements where popped");
    }
}
