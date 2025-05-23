using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] CostumeColors = new int[n, 2];


        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            CostumeColors[i, 0] = int.Parse(input[0]);
            CostumeColors[i, 1] = int.Parse(input[1]);
        }

        int total = 0;

        for (int i = 0; i < n; i++)
        {
            for (global::System.Int32 j = 0; j < n; j++)
            {
                if (i != j)
                {
                    if (CostumeColors[i, 0] == CostumeColors[j, 1])
                    {
                        total++;
                    }
                }

            }
        }

        Console.WriteLine(total);



    }
}