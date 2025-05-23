using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // قراءة النص وإزالة الأقواس فقط
        string input = Console.ReadLine().Trim('{', '}');

        // تقسيم النص بناءً على ", " مباشرةً
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(0);
        }
        else
        {
            HashSet<string> uniqueLetters = new HashSet<string>(input.Split(", "));
            Console.WriteLine(uniqueLetters.Count);
        }
    }
}