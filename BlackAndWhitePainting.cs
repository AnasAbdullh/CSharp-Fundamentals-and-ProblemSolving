/*using System;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            var Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = Numbers[0];
            int m = Numbers[1];
            int c = Numbers[2];

            if (n == 0 && m == 0 && c == 0)
            {
                break;
            }

            if (c == 0)
            {
                Console.WriteLine((long)(n - 7) * (m - 7) / 2);
            }
            else
            {
                Console.WriteLine((long)(n - 7) * (m - 7) / 2);
            }


        }
    }
}*/


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            var Numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = Numbers[0];
            int m = Numbers[1];
            int c = Numbers[2];

            if (n == 0 && m == 0 && c == 0)
            {
                break;
            }

            long total = (long)(n - 7) * (m - 7) / 2;

            if (((n - 7) * (m - 7)) % 2 == 1 && c == 1)
            {
                total++; // نضيف 1 إذا كان العدد فرديًا والزاوية المطلوبة بيضاء
            }

            Console.WriteLine(total);
        }
    }
}
