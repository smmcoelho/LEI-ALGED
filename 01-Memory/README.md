
# Simple Memory Example (C#)

This repository contains a small C# example that demonstrates how **memory is organized**
between the **stack** and the **heap** in a typical C# program.

## Example Code

The following code is defined in `SimpleExample.cs`:

```csharp
int x = 42;
string name = "Sebastian";
int[] numbers = [1, 2, 3, 4, 5];
```

The diagram below illustrates how these three lines of code look "under the hood" during execution:
![C# Stack and Heap Memory Layout](SimpleMemoryMap.png)


## Key Concepts
### The Stack: The "Active" Workspace
The Stack is a fast, organized memory region that follows a LIFO (Last-In, First-Out) structure.
- Direct Storage: It stores Value Types (like int, bool, struct) directly. In our code, x lives entirely on the stack.
- Pointers: It stores References (memory addresses) for objects that live on the Heap. The variables name and numbers on the stack are just "directions" pointing to where the real data is.
- Automatic: Memory is reclaimed instantly as soon as the method (scope) finishes.

### The Heap: The "Storage" Warehouse
The Heap is a large, flexible pool of memory used for Reference Types.
- Object Storage: This is where the actual content of strings, arrays, and class instances resides.
- Dynamic: Objects can live here even after the method that created them has ended, as long as something is still pointing to them.
- Garbage Collection (GC): Unlike the Stack, memory here isn't cleared instantly. The Garbage Collector periodically scans the heap to delete objects that are no longer being used.

## Summary Table

| Variable | Type Category | Stack Contents | Heap Contents |
| :--- | :--- | :--- | :--- |
| **`x`** | Value Type | The actual value (**`42`**) | *None* |
| **`name`** | Reference Type | **Memory Address** (Pointer) | The string object `"Sebastian"` |
| **`numbers`** | Reference Type | **Memory Address** (Pointer) | The array object `[1, 2, 3, 4, 5]` |
