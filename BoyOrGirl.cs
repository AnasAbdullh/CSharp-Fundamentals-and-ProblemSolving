using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {

        string UserName = Console.ReadLine();

        HashSet<char> uniqueChars = new HashSet<char>(UserName);

        if (uniqueChars.Count % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }


    }

}