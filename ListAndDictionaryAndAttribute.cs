using System;
using System.Reflection;
using System.Collections.Generic;

using System.Linq;


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DeveloperAttribute : Attribute
{
    public string Name { get; set; }
    public string Date { get; set; }

    public DeveloperAttribute(string name, string date)
    {
        Name = name;
        Date = date;
    }


}

class Employee
{
    public int Id { set; get; }
    public string Name { set; get; }
    public int? ReportTo { set; get; }

    public override string ToString()
    {
        return $"{Name} {Id}";
    }

}

//[Developer("Anas", "2025-04-03")]
class Person
{
    public string Name = "Anas";
    public int Age = 21;


    public override bool Equals(object? obj)
    {
        Person p = obj as Person;
        return this.Name == p.Name && this.Age == p.Age;
    }

    void Main()
    {
        var str = "Anas Abdallh Awadh Saleh";
        Dictionary<char, List<string>> Dic = new Dictionary<char, List<string>>();


        //  Console.WriteLine(Dic.ContainsKey('A'));
        foreach (var item in str.Split())
        {
            foreach (var item1 in item)
            {
                if (!Dic.ContainsKey(item1))
                {
                    Dic.Add(item1, new List<string> { item });
                }
                else
                {
                    Dic[item1].Add(item);
                }

            }
        }

        foreach (var item in Dic)
        {
            //  Console.WriteLine(item.Key);

            foreach (var item1 in item.Value)
            {
                //  Console.WriteLine(item1);
            }
        }


        List<Employee> Emp = new List<Employee>()
        {
            new Employee { Id = 100,Name = "Anas",ReportTo = 10},
            new Employee { Id = 120,Name = "Ali",ReportTo = 20}
        };

        var managers = Emp.ToLookup(x => x.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());

        Console.WriteLine(managers[20][0]);
        //Console.WriteLine(managers);

        foreach (var item in managers)
        {
            //  Console.WriteLine(item.Key);
            foreach (var item1 in item.Value)
            {
                // Console.WriteLine(item1);
            }
        }

        var emp = Emp.FirstOrDefault(x => x.Id == 1006);
        // Console.WriteLine(emp == null);

    }

    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}

class Program
{
    static void Main()
    {
        var Num = new int[] { 10, 20, 30, 40, 50 };

        foreach (var item in Num)
        {
            // Console.WriteLine(item);
        }

        var attr1 = new DeveloperAttribute("Anas", "San");
        var attr2 = new DeveloperAttribute("Anas", "San");

        Console.WriteLine(attr1 == attr2);         // False
        Console.WriteLine(attr1.Equals(attr2));    // False

        List<int> Array = new List<int>(Num);

        List<Person> P = new List<Person>();
        P.Add(new Person { Name = "Anas", Age = 21 });
        P.Remove(new Person { Name = "Anas", Age = 21 });

        foreach (var item in P)
        {
            Console.WriteLine(item.Age);
        }




        //List<DeveloperAttribute> test = new List<DeveloperAttribute>();
        //test.Add(new DeveloperAttribute("Anas", "San"));

        //  test.Remove(new DeveloperAttribute("Anas", "San"));
        //test.Remove(new DeveloperAttribute { Name = "Anas", Date = "San" });







        // Array.InsertRange(1, Num);

        // Console.WriteLine("ttt");

        foreach (var item in Array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(Array.Count);
        Console.WriteLine(Array.Capacity);


        //Console.WriteLine($"\n{Array[9]}");



    }
}