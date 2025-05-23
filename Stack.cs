using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Program
{
    static void Main()
    {
        var num = new int[] { 1, 2, 3, 4, 5, 6 };
        var undeo = new Stack<int>(num);
        var Redo = new Stack<int>();


        while (undeo.Count > 0)
        {
            Console.WriteLine(undeo.Peek());
            var number = undeo.Pop();
            Redo.Push(number);
        }


        foreach (var item in Redo)
        {
            Console.WriteLine(item);
        }

    }
}