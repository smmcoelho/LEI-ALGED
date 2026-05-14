

static void Print2DArray(int[,, ] array3D)
{
    // Display the array elements.
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                System.Console.Write($"{array3D[i, j, k]} ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}



int[,,] array3D = { { { 1, 2, 3 }, { 4,   5,  6 } }, 
    { { 7, 8, 9 }, { 10, 11, 12 } } };

Print2DArray(array3D);