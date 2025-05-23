using System;
using System.Diagnostics;


public static class Program
{

    public static void Main()
    {

        /*string S1 = null;

        //S1 = S1 ?? "Anas";

        // var S2 = S1?.ToUpper();

        var S2 = S1 is null ? null : S1.ToUpper();

        Console.WriteLine(S2);
        {
            Console.WriteLine("!");
        }


        string? userName = null;
        string displayName = userName ?? "Guest";  // إذا كان userName فارغًا، يتم استخدام "Guest"
        Console.WriteLine(displayName); // "Guest"

        Func<int, int> square = x => x * x;
        Console.WriteLine(square(4)); // 16

        if (true)
        {
            Console.WriteLine(";");
        }

        object Number = 6;

        switch (Number)
        {
            case int:
                {
                    Console.WriteLine($"This is number {Number}");
                    break;
                }

        }

        bool vip = false;

        switch (vip)
        {
            case true:
                {
                    Console.WriteLine($"This is number {Number}");
                    break;
                }

        }


        switch (vip)
        {
            case bool i when i == true:
                {
                    Console.WriteLine($"This is number {Number}");
                    break;
                }

            case bool:
                {
                    Console.WriteLine($"This is number 3 {Number}");
                    break;
                }



        }

        var Boker = 7;

        string Result = Boker switch
        {
            1 => "Anas",
            2 => "Ali",
            _ => Boker.ToString()

        };

        Console.WriteLine(Result);*/



        var first = 1;
        var Scounds = 0;
        var Result = 0;



        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(Result);

            Result = first + Scounds;
            first = Scounds;
            Scounds = Result;

        }


        /*for (; ; )
        {
            //Console.WriteLine("6");



        }*/


        foreach (var i in "Anas")
        {
            Console.WriteLine(i);
        }

        var v = 0;

start:
        if (v < 5)

            Console.Write(v + " ");
        v++;

        goto start;






    }


}

