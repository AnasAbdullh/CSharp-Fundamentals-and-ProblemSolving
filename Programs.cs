
using System;
using System.Linq;

public static class Program
{
    public static void Print<T>(this T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        string[] names = { "Anas", "Abdallah", "Awadh", "Abdy", "Hoidy" };

        numbers.Print();
        names.Print();

        int[,] Sudoko =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12},
        };

        Console.WriteLine("Anas", Sudoko[0, 2]);

        var anas = new string[][]
        {
            new string[] {"Anas", "Abdallah"},
            new string[] {"1"},
        };

        //Console.WriteLine(anas[1][0]);

        var temp = 2..^2;

        // This line will cause an IndexOutOfRangeException because temp only has 2 elements (indices 0 and 1).
        //temp.Print();

        Console.WriteLine(temp);
    }
}
