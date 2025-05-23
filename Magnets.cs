using System;


public static class Program
{
    public static void Main()
    {
        var NumberMagnets = Convert.ToInt32(Console.ReadLine());

        string[] Magnets = new string[NumberMagnets];

        for (int i = 0; i < Magnets.Length; i++)
        {
            Magnets[i] = Console.ReadLine();
        }

        int GroupsOfMagnets = 1;

        for (int i = 1; i < Magnets.Length; i++)
        {

            if (Magnets[i] != Magnets[i - 1])
            {
                GroupsOfMagnets++;
            }
        }

        Console.WriteLine(GroupsOfMagnets);

    }
}

