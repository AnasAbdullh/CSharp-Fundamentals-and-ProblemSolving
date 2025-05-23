using System;


public static class Program
{
    public static void Main()
    {
        var letters = Console.ReadLine();

        int uppercase = 0;
        int lowercase = 0;


        foreach (var item in letters)
        {
            if (char.IsUpper(item))
            {
                uppercase++;
            }
            else
            {
                lowercase++;
            }
        }

        if (lowercase >= uppercase)
        {
            Console.WriteLine(letters.ToLower());
        }
        else
        {
            Console.WriteLine(letters.ToUpper());
        }

    }
}

