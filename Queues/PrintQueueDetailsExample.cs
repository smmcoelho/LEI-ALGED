static void PrintQueueDetails(Queue<string> queue)
{
    Console.WriteLine($"Count: {queue.Count} an Capacity: {queue.Capacity}");
}

var queue = new Queue<string>();
PrintQueueDetails(queue);

queue.Enqueue("Albert");
PrintQueueDetails(queue);

queue.Enqueue("John");
queue.Enqueue("Quentin");
queue.Enqueue("Albert");
queue.Enqueue("John");
PrintQueueDetails(queue);

Console.WriteLine(queue.Dequeue()); // Output: Alice

PrintQueueDetails(queue);

