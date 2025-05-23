using System;

class Program
{
    static void Main()
    {
        // قراءة المدخلات الأساسية
        string[] inputValues = Console.ReadLine().Split();
        int n = int.Parse(inputValues[0]);
        int b = int.Parse(inputValues[1]);
        int d = int.Parse(inputValues[2]);

        // قراءة أحجام البرتقال
        string[] orangeSizes = Console.ReadLine().Split();

        int waste = 0;  // مجموع الفضلات
        int emptyCount = 0;  // عدد مرات التفريغ

        for (int i = 0; i < n; i++)
        {
            int orangeSize = int.Parse(orangeSizes[i]);

            if (orangeSize <= b)
            {
                waste += orangeSize;

                if (waste > d)
                {
                    waste = 0;
                    emptyCount++;
                }
            }
        }

        // طباعة عدد مرات التفريغ
        Console.WriteLine(emptyCount);
    }
}
