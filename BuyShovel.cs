using System;

class Program
{
    static void Main()
    {
        int[] BuyShovel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int k = BuyShovel[0];
        int r = BuyShovel[1];


        for (int i = 1; i <= 10; i++)
        {

            int Total = k * i;
            int LastDigit = Total % 10;


            if (LastDigit == r || LastDigit == 0)
            {
                Console.WriteLine(i);
                return;
            }

        }

    }
}


