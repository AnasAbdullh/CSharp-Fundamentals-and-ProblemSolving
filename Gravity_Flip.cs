using System;

public class Program
{
    public static void Main()
    {
        // قراءة عدد الأعمدة
        int n = int.Parse(Console.ReadLine());

        // قراءة عدد المكعبات في كل عمود وتحويلها إلى مصفوفة
        int[] cubes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // تطبيق خوارزمية الترتيب الفقاعي (Bubble Sort)
        /*for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // إذا كان العنصر الحالي أكبر من العنصر التالي، نقوم بتبديلهما
                if (cubes[j] > cubes[j + 1])
                {
                    // التبديل بين العناصر
                    int temp = cubes[j];
                    cubes[j] = cubes[j + 1];
                    cubes[j + 1] = temp;
                }
            }

            // 4
            // 3 2 1 2

        }*/

        Array.Sort(cubes);

        Console.WriteLine(string.Join(" ", cubes));

    }



}