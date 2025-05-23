
using System;

class Program
{
    static void Main()
    {
        // قراءة المدخلات
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // طول الكلمة المرور
        int k = int.Parse(input[1]); // عدد الأحرف المختلفة

        var Password = new char[n];

        for (int i = 0; i < n; i++)
        {
            Password[i] = (char)('a' + (i % k));
        }

        Console.WriteLine(new string(Password));


    }


}