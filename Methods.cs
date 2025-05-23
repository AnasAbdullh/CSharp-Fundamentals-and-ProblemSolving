using System;
using Employees;



class Program
{

    public static void Main()
    {
        MyClass cls = new MyClass();
        var i = 0;
        cls.PrintName(ref i);
        Console.WriteLine(i);
        MyClass.IsEven(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });



        //Console.WriteLine(IsVip("vip"));
    }

    public static bool IsVip(string vip) => vip == "vip";



    public class MyClass
    {
        public void PrintName(ref int i)
        {
            //  Console.WriteLine("Anas");
            i++;
        }

        public static void IsEven(int[] Original)
        {
            foreach (var i in Original)
            {

                if (Bay(i))
                {
                    Console.WriteLine(i);
                }

            }

            bool Bay(int pay) => pay % 2 == 0;
        }
    }


}