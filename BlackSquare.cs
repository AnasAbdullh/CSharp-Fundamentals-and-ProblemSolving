using System;

class Program
{
    static void Main()
    {

        int[] Calories = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        string BlackSquare = Console.ReadLine();

        int result = 0;

        foreach (var item in BlackSquare)
        {
            result = result + Calories[(item - '0') - 1];
        }

        Console.WriteLine(result);

    }

}