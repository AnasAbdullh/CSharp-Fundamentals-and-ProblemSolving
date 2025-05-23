using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Number N = new Number(10);
        Number N1 = new Number(20);

        //Console.WriteLine(N + N1);
        //Number N3 = N + N1;
        //  Console.WriteLine(N3.Num);

        Number N4 = NewClass();
        Console.WriteLine(N4.Num);

        Number1 u = new Number1(22);

        Console.WriteLine(u + N);



    }

    public static Number NewClass()
    {
        return new Number(12);
    }



}

class Number1
{

    public int Num;

    public Number1(int Num)
    {
        this.Num = Num;
    }


};



class Number
{

    public int Num;

    public Number(int Num)
    {
        this.Num = Num;
    }

    public static Number operator +(Number num1, Number1 num2)
    {
        return new Number(num1.Num + num2.Num);
    }

    public static int operator +(Number1 num2, Number num1)
    {
        return num1.Num + num2.Num;
    }



};


