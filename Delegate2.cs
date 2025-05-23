using System;
using System.Linq;

class Program
{

    delegate void MyInformation(byte Age);
    delegate int Numbers(int Num);
    delegate void AnyThing();


    static void MyMethod(string child1, string child2, string child3)
    {
        Console.WriteLine("The youngest child is: " + child3);
    }

    static int MyAge(int i)
    {
        if (i == 2)
        {
            return 0;
        }
        return i;
    }

    static void Main()
    {
        int[,] x = new int[2, 3];
        Console.WriteLine(x[0, 1]);

        var jaggedArr = new int[2][];
        jaggedArr[0] = new int[3];
        jaggedArr[1] = new int[4];

        jaggedArr[0][0] = 10;

        Console.WriteLine(jaggedArr[1][3]);


        // Note that we used System.Linq above.

        /*int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

        // get the minimum element
        Console.WriteLine("Smallest  Element: " + numbers.Min());

        // Max() returns the largest number in array
        Console.WriteLine("Largest Element: " + numbers.Max());*/

        int[] numbers = { 20, 22, 19, 18, 1 };



        // compute Count
        Console.WriteLine("Count : " + numbers.Count());

        // compute Sum
        Console.WriteLine("Sum : " + numbers.Sum());

        // compute the average
        Console.WriteLine("Average: " + numbers.Average());

        Console.WriteLine(Math.Round(9.99));

        //see the order of sending parameters is not important.

        MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");

        Console.WriteLine(MyAge(i: 10));

        try
        {
            Console.WriteLine(new int[] { 10, 20, 30 }[77]);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }


        //Console.WriteLine(new Random().Next(10, 20));

        MyInformation anas = new MyInformation(MyAge);
        anas += MyName;
        anas.Invoke(1);

        MyInformation v;

        v = MyAge;
        // v = Delegate(byte Age) { Age = 12};

        Numbers num;
        num = (int i) => i == 1 ? 12 : 33;

        Console.WriteLine(Num(e => e = 12));

        AnyThing Any = () => Console.WriteLine("Anas");

        Any();



    }



    static int Num(Numbers num)
    {
        if (num(12) == 12)
        {
            return 10;
        }
        return 20;
    }


    static void MyAge(byte Age)
    {
        Console.WriteLine(Age);
    }

    static void MyName(byte Name)
    {
        Console.WriteLine(Name + 123);
    }


}