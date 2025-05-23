using System;
using System.Linq;

public class Program
{
    static public int Sum(int i, Equal g)
    {
        if (g(i == 50))
        {
            return i;
        }

        return 0;
    }

    public static void Sum(int i, int c)
    {
        Console.WriteLine($"{i + c}");
    }

    public static void Mult(int i, int c)
    {
        Console.WriteLine($"{i * c}");
    }

    public delegate void Oper(int i, int c);




    static void Main()
    {

        var Anas = new MyClass();
        Anas.MyProperty = 10;
        // Console.WriteLine(Anas.MyProperty);

        var empt = new MyClass[]
        {
            new MyClass {MyProperty = 10},
            new MyClass {MyProperty = 20},

        };

        /*foreach (var item in empt)
        {
            Console.WriteLine(item.MyProperty);
        }*/

        // Console.WriteLine(Sum(10, i => 10 == 10));

        Oper reat;
        reat = Sum;
        reat += Mult;

        reat(10, 20);


    }
}

public delegate bool Equal(bool i);


public class MyClass
{
    public int MyProperty { get; set; }
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; set; }
}