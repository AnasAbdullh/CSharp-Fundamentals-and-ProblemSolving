using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] Cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int Sereja = 0;
        int Dima = 0;

        int Left = 0;
        int Right = n - 1;

        int turn = 0;

        while (Left <= Right)
        {
            int chose;
            if (Cards[Left] > Cards[Right])
            {
                chose = Cards[Left];
                Left++;
            }
            else
            {
                chose = Cards[Right];
                Right--;
            }

            if (turn == 0)
            {
                Sereja += chose;
            }
            else
            {
                Dima += chose;
            }

            turn = 1 - turn;
        }

        Console.WriteLine($"{Sereja} {Dima}");

    }

}