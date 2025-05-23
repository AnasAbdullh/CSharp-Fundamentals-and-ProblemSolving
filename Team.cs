using System;
using Validate;

public static class Program
{
    public static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = inputs[0] + inputs[1] + inputs[2];

            if (sum >= 2)
                result++;
        }

        Console.WriteLine("\n" + result);



    }
}

