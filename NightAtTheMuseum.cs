using System;

class Program
{
    static void Main()
    {
        string exhibitName = Console.ReadLine(); // قراءة اسم المعرض

        char currentLetter = 'a'; // نبدأ دائماً من الحرف 'a'
        int totalRotations = 0; // متغير لتخزين إجمالي الدورانات

        foreach (char targetLetter in exhibitName)
        {
            // حساب المسافة في الاتجاه مع عقارب الساعة
            int clockwiseDistance = Math.Abs(targetLetter - currentLetter);

            // حساب المسافة في الاتجاه عكس عقارب الساعة
            int counterClockwiseDistance = 26 - clockwiseDistance;

            // اختيار أصغر مسافة من بين الاتجاهين
            totalRotations += Math.Min(clockwiseDistance, counterClockwiseDistance);

            // تحديث موقع العجلة إلى الحرف الجديد
            currentLetter = targetLetter;
        }

        Console.WriteLine(totalRotations);
    }
}