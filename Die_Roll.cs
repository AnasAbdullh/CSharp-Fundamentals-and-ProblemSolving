using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int Y = int.Parse(input[0]);
        int W = int.Parse(input[1]);

        int maxRoll = Math.Max(Y, W);
        int winningCases = 6 - maxRoll + 1;

        int gcd = (int)BigInteger.GreatestCommonDivisor(winningCases, 6);

        Console.WriteLine($"{winningCases / gcd}/{6 / gcd}");
    }
}