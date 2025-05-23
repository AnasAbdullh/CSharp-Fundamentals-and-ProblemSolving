using System;
using System.Linq;

class Program
{

    static void Main()
    {
        num = i => Console.WriteLine($"{i} 1");
        num += i => Console.WriteLine($"{i} 2");

        Int(1);
        num -= i => Console.WriteLine($"{i} 2");
        Int(1);
        num = Print;
        Int(2);
        num -= Print;
        Int(17);


    }

    static void Print(int name)
    {
        Console.WriteLine(name);
    }



    delegate void Number(int Number);

    static event Number num;

    static void Int(int i)
    {
        if (num != null)
        {
            num(i);
        }
    }

}