using System;
using System.Linq;

class Program
{
    static void Main()
    {

        for (int i = 0; i < 3; i++)
        {
            var Number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (GCD(Number[0], Number[1]) == 1)
            {
                Console.WriteLine($"{Number[0]}   {Number[1]}    Good Choice");
            }
            else
            {
                Console.WriteLine($"{Number[0]}   {Number[1]}    bad Choice");

            }
        }

    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            var values = input.Split();
            int step = int.Parse(values[0]);
            int mod = int.Parse(values[1]);

            string result = BigInteger.GreatestCommonDivisor(step, mod) == 1 ? "Good Choice" : "Bad Choice";

            Console.WriteLine($"{step,10}{mod,10}    {result}\n");
        }
    }
}