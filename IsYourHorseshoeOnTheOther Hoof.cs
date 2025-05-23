using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] horseshoe = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        HashSet<int> uniqueNumbers = new HashSet<int>(horseshoe);

        Console.WriteLine(horseshoe.Length - uniqueNumbers.Count);


    }
}