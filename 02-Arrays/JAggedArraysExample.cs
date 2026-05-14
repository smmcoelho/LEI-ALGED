// 1.  Change arr[1] = []; what do you observe? Why?
// 2. Do the necessary changes to make it work

static void PrintJaggedArray(int[][] arr)
{
    int index = 0;
    foreach (var row in arr)
    {
        Console.WriteLine($"Element({index++}): {string.Join(" ", row)}");
    }
}


// Declare the array of three elements.
var arr = new int[3][];

// Initialize the elements.
arr[0] = [1, 3, 5, 7, 9];
arr[1] = [2, 4, 6, 8];
arr[2] = [2, 4];

// Assign 10 to the second element ([1]) of the first array ([0]):
arr[1][0] = 10;

// Display the array elements.
PrintJaggedArray(arr);
    
    
/* Output:
    Element(0): 1 3 5 7 9
    Element(1): 2 4 6 8
*/