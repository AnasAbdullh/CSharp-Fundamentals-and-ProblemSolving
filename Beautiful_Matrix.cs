using System;

public static class Program
{
    public static void Main()
    {
        int[,] matrix = new int[5, 5];

        
        for (int i = 0; i < 5; i++)
        {
            string[] row = Console.ReadLine().Split(); 
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = int.Parse(row[j]); 
            }
        }

        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] == 1)
                {
                    Console.WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
                    return;
                }
            }
        }
    }
}