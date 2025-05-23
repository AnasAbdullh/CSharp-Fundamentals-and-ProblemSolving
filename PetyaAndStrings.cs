using System;
using System.Text;

public class Program
{
    public static void Main()
    {

        /*char i = 't';
        int c = (int)('t' + 'c');
        Console.WriteLine((int)i);
        Console.WriteLine(c);*/

        string A = Console.ReadLine().ToLower();
        string B = Console.ReadLine().ToLower();

        int resultA = 0;
        int resultB = 0;



        for (int i = 0; i < A.Length; i++)
        {
            resultA = resultA + A[i];
            resultB = resultB + B[i];
        }


        if (resultA == resultB)
        {
            Console.WriteLine("0");
        }
        else if (resultA < resultB)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine("1");
        }


        Console.WriteLine(A.CompareTo(B));

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < B[i])
            {
                Console.WriteLine("-1");
                break;
            }
            else if (A[i] > B[i])
            {
                Console.WriteLine("1");
                break;
            }

        }

        Console.WriteLine("0");

    }

}