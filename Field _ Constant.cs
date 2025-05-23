using System;
using Employees;


namespace Employees;

public class clsEmployee
{
    public const double TAX = 0.03;

    public string FirstName;
    public string LastName;
    public int Wage;
    public int loggedHour;
}



class Program
{

    public static double TotalTax(int Wage, int loggedHour, double Tax)
    {
        return Wage * loggedHour - (Wage * loggedHour * Tax);
    }

    public static void Main()
    {

        clsEmployee S1 = new clsEmployee();


        S1.FirstName = "Aans";
        S1.LastName = "Abdallah";
        S1.Wage = 10;
        S1.loggedHour = 10;

        clsEmployee[] arr = new clsEmployee[1];
        arr[0] = S1;
        S1.Wage = 20;

        Console.WriteLine(arr[0].Wage);
        Console.WriteLine(S1.Wage);


        int n = Console.Read();

        Console.WriteLine(n);




        //Console.WriteLine(S1);

        //Console.WriteLine("Hash Code of arr: " + S1.GetHashCode());
        //Console.WriteLine(TotalTax(S1.Wage, S1.loggedHour, clsEmployee.TAX));


    }

}