using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Program
{
    static void Main()
    {
        var num = new int[] { 1, 2, 3, 4, 5, 6 };

        LinkedList<int> Node = new LinkedList<int>(num);

        //Console.WriteLine(Node.Last());
        //Console.WriteLine(Node.First());

        // Node.AddAfter(Node.Last.Value, 20);
        Console.WriteLine(Node.Last.Value);

        Console.WriteLine(Node.Last.Next is null);


        foreach (var item in Node)
        {
            Console.WriteLine(item);
        }
    }
}