using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var n = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == 0)
            {
                break; // استخدم break بدلاً من return للخروج من الحلقة
            }

            if (n[i] >= 0 && Math.Sqrt(n[i]) * Math.Sqrt(n[i]) == n[i]) // التحقق من أن العدد غير سالب
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}