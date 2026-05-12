// 1. Create a class Person with the name and the status (bool)
// 2. Enqueue various Persons with status active and deactive
// 3. Print only the active persons

var queue = new Queue<string>();
queue.Enqueue("Albert");
queue.Enqueue("John");
queue.Enqueue("Quentin");

Console.WriteLine(queue.Dequeue()); // Output: Alice
Console.WriteLine(queue.Peek());    // Output: Barbara
Console.WriteLine(queue.Count);     // Output: 2