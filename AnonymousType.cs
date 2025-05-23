
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
{
internal class Program
{

    static void Main(string[] args)
    {

        //you dont specify any type here , automatically will be specified
        /* var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

         Console.WriteLine("\nExample1:\n");
         Console.WriteLine(student.Id); //output: 20
         Console.WriteLine(student.FirstName); //output: Mohammed
         Console.WriteLine(student.LastName); //output: Abu-Hadhoud

         //You can print like this:
         Console.WriteLine(student);


         //anonymous types are read-only
         //you cannot change the values of properties as they are read-only.

         // student.Id = 2;//Error: cannot chage value
         // student.FirstName = "Ali";//Error: cannot chage value


         //An anonymous type's property can include another anonymous type.
         var student2 = new
         {
             Id = 20,
             FirstName = "Mohammed",
             LastName = "Abu-Hadhoud",
             Address = new { Id = 1, City = "Amman", Country = "Jordan" }
         };

         Console.WriteLine("\nExample2:\n");
         Console.WriteLine(student2.Id);
         Console.WriteLine(student2.FirstName);
         Console.WriteLine(student2.LastName);

         Console.WriteLine(student2.Address.Id);
         Console.WriteLine(student2.Address.City);
         Console.WriteLine(student2.Address.Country);
         Console.WriteLine(student2.Address);

         var person1 = new Person { Name = "Anas", Age = 21 };
         var person2 = new Person { Name = "Anas", Age = 21 };

         Console.WriteLine(person1.Equals(person2)); // ✅ True (لأن القيم متساوية)
         Console.WriteLine(person1);                                     //  Console.WriteLine(person1.GetHashCode());
         Console.ReadKey();*/

        var MyTest = new { name = "Anas", Age = 21, EnyThing = new { agag = 3 } };
        Console.WriteLine(MyTest.GetHashCode());

    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            Console.WriteLine(this.Name + other.Name);
            return this.Name == other.Name && this.Age == other.Age;

        }
        return false;
    }
}


}