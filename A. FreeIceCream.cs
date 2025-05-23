using System;

class Program
{
    static void Main()
    {

        string[] IceCream = Console.ReadLine().Split();

        int n = int.Parse(IceCream[0]);
        long x = int.Parse(IceCream[1]);

        int TheTroubled = 0;

        for (int i = 0; i < n; i++)
        {
            string di = Console.ReadLine();
            int Number = int.Parse(di.Substring(2));

            if (di[0] == '+')
            {
                x += Number;
            }
            else
            {
                if (Number <= x)
                {
                    x -= Number;
                }
                else
                {
                    TheTroubled++;
                }

            }

        }

        Console.WriteLine($"{x} {TheTroubled}");


    }
}