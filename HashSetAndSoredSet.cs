using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net.Http;


public class Program
{
    static void Main()
    {
        var x = new Exam { Name = "Anas", Age = 21 };
        var y = new Exam { Name = "Anas", Age = 21 };

        var Hash = new HashSet<Exam>();
        Hash.Add(x);
        Hash.Add(y);

        foreach (var item in Hash)
        {
            Console.WriteLine(item);
        }




        var hash = new HashSet<string>();
        var sorted = new SortedSet<string>();



        hash.Add("Anas");
        hash.Add("Salem");
        hash.Add("Ali");
        hash.Add("Anas");

        hash.Remove("Anas");


        sorted.Add("Anas");
        sorted.Add("Salem");
        sorted.Add("Ali");
        Console.WriteLine("Sum");
        Console.WriteLine(sorted.Index);

        Console.WriteLine("HashSet:");
        foreach (var name in hash)
            Console.WriteLine(name);

        Console.WriteLine("\nSortedSet:");
        foreach (var name in sorted)
            Console.WriteLine(name);


    }


    class Exam
    {
        public string Name;
        public byte Age;

        public override int GetHashCode()
        {

            return 463626;
        }

        public void Compre(object? obj)
        {
            var Obj = obj as Exam;
            Console.WriteLine(this.Age.Equals(Obj.Age));
        }

        public override bool Equals(object? obj)
        {
            var Ob = obj as Exam;
            /*Console.WriteLine("----------");
            Console.WriteLine(this.Age.GetHashCode());
            Console.WriteLine(Ob.Age.GetHashCode());
            Console.WriteLine(object.ReferenceEquals(this.Age, Ob.Age));
            Console.WriteLine("----------");*/

            return this.Age.Equals(Ob.Age);
        }

        public override string ToString()
        {
            return $"\n{Name} {Age}\n";
        }


    }
}