using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();

        int position = 0;

        foreach (char instruction in t)
        {
            if (instruction == s[position])
            {
                position++;
            }
        }

        Console.WriteLine(position + 1);

    }
}


