using System;

public static class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // عدد الكعكات المطلوبة
        int t = int.Parse(input[1]); // الزمن اللازم للخبز
        int k = int.Parse(input[2]); // عدد الكعكات لكل دفعة
        int d = int.Parse(input[3]); // زمن بناء الفرن الثاني

        // الزمن المطلوب باستخدام فرن واحد
        int timeWithOneOven = ((n + k - 1) / k) * t;

        // إذا كان الفرن الأول وحده يستطيع إنهاء المهمة قبل بناء الفرن الثاني، فلا فائدة منه
        if (d >= timeWithOneOven)
        {
            Console.WriteLine("NO");
            return;
        }

        // n t k d

        // 8 6 4 6

        // تجربة الزمن عند استخدام فرنين
        int timeWithTwoOvens = 0;
        int cakesBaked = 0;
        int oven1NextBake = t; // متى سيخبز الفرن الأول دفعة جديدة
        int oven2NextBake = d + t; // متى سيخبز الفرن الثاني دفعة جديدة

        while (cakesBaked < n)
        {
            if (oven1NextBake <= oven2NextBake)
            {
                cakesBaked += k;
                timeWithTwoOvens = oven1NextBake;
                oven1NextBake += t;
            }
            else
            {
                cakesBaked += k;
                timeWithTwoOvens = oven2NextBake;
                oven2NextBake += t;
            }

        }
        // إذا كان الزمن مع فرنين أقل من الفرن الواحد، نطبع "YES"
        Console.WriteLine(timeWithTwoOvens < timeWithOneOven ? "YES" : "NO");
    }
}