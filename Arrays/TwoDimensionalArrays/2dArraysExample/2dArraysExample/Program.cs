int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };


//Show results
foreach (int i in numbers2D)
{
    System.Console.Write($"{i} ");
}
// Output: 9 99 3 33 5 55


//Show results
for (int row = 0; row < numbers2D.GetLength(0); row++)
{
    for (int col = 0; col < numbers2D.GetLength(1); col++)
    {
        Console.Write($"{numbers2D[row, col]} ");
    }
    Console.WriteLine();
}

//Show results 
for (int row = 0; row < numbers2D.GetLength(0); row++)
{
    Console.WriteLine(
        $"| {numbers2D[row, 0],3} | {numbers2D[row, 1],3} |"
    );
}

