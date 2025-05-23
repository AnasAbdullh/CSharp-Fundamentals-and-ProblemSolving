using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string NumberStones = Console.ReadLine();

        int take = 0;


        for (int i = 0; i < n - 1; i++)
        {
            if (NumberStones[i] == NumberStones[i + 1])
            {
                take++;
            }
        }

        Console.WriteLine(take);


    }

}