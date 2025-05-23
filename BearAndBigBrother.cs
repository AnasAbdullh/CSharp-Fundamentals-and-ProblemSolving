using System;
using Validate;

public static class Program
{
    public static void Main()
    {

        int SizeLimak = 4;
        int SizeBob = 9;
        int count = 0;

        while (SizeBob >= SizeLimak)
        {
            SizeLimak = SizeLimak * 3;
            SizeBob = SizeBob * 2;
            count++;

        }

        Console.WriteLine(count);

    }
}

