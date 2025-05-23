using System;
using System.Numerics;
using System.Linq;

public class Program
{

    static void Main()
    {

        var Numbers = new string[4];

        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = Console.ReadLine();
        }

        for (int i = 0; i < Numbers.Length; i += 2)
        {
            if (Numbers[i].Length > 10 || Numbers[i + 1].Length > 10)
            {
                Console.WriteLine(BigInteger.Parse(Numbers[i]) * BigInteger.Parse(Numbers[i + 1]));
            }
            else
            {
                Console.WriteLine(int.Parse(Numbers[i]) * int.Parse(Numbers[i + 1]));
            }

        }

    }
}