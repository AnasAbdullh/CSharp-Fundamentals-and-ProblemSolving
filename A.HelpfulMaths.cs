using System;
using System.Linq;
class Program
{
    static void Main()
    {

        int[] HelpfulMaths = Console.ReadLine().Split('+').Select(int.Parse).ToArray();

        Array.Sort(HelpfulMaths);

        Console.WriteLine(string.Join("+", HelpfulMaths));


    }
}