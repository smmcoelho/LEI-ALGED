public class Program
{
    static void Print(int[,] numbers2D)
    {
        for (int row = 0; row < numbers2D.GetLength(0); row++)
        {
            for (int col = 0; col < numbers2D.GetLength(1); col++)
            {
                Console.Write($"{numbers2D[row, col]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-------------");
    }
    
    public static void Main()
    {
        int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };
        
        //Show results
        Print(numbers2D);
        
        //Change values
        numbers2D[1, 0] = 100;
        numbers2D[1, 0] = 200;
        
        //Show results
        Print(numbers2D);
    }
}   
