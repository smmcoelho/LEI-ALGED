
public class Action
{
    public Action(string id, string t)
    {
        Id = id;
        Type = t;
    }

    public string Id { get; }
    public string Type { get; }

    public override string ToString() => $"({Id}, {Type})";
}

public class Program
{
    static void PrintStackDetails<T>(Stack<T> queue)
    {
        Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
    }

    public static void Main()
    {
        var actionsStack = new Stack<Action>();
        var element1 = new Action("20", "Write");

        actionsStack.Push(element1);
        PrintStackDetails(actionsStack);

        actionsStack.Push(new Action("21", "Draw"));
        PrintStackDetails(actionsStack);

        Console.WriteLine($"Dequeue: {actionsStack.Pop()}");
        PrintStackDetails(actionsStack);
    }
}

