using System;
using Employees;








class Program
{

    public static void Main()
    {
        MyClass cls = new MyClass(1, 2, 3);

        Console.WriteLine(cls.i);
        //Console.WriteLine(MyClass.y);
        Console.WriteLine(cls.t);

        MyClass cls1 = new MyClass
        {
            i = 7,
            t = 9,
            y = 8,

            // MyClass.y = 10,

        };


        MyClass cls2 = new MyClass(100)
        {
            t = 9,
            //MyClass.y = 10,

        };

        MyClass1 S2;
        MyClass d;



        //MyClass.IsEven(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


        //Console.WriteLine(IsVip("vip"));
    }

    public static bool IsVip(string vip) => vip == "vip";



    public class MyClass
    {

        public int i = 0;
        public int y = 0;
        public int t = 0;

        public MyClass(int i, int y, int t)
        {
            this.i = i;
            this.y = y;
            this.t = t;

        }

        public MyClass()
        {

        }


        public MyClass(int i)
        {
            // this.i = i;
        }


        // public MyClass(int i) : this(i, 5, 7) { }


        public void Name()
        {
            y++;
        }

        public static void set()
        {

        }

    }


    public class MyClass1
    {

        private MyClass1()
        {

        }

        private MyClass1(int i)
        {
            Console.WriteLine(i);
        }


        public static MyClass1 CreateConstercture(int i)
        {
            return new MyClass1(i);
        }


    }


}