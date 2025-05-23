using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"🔹 الذاكرة الحالية: {GC.GetTotalMemory(false)}");

        byte[] data = new byte[10_000_000]; // تخصيص 10MB
        Console.WriteLine($"🔹 بعد تخصيص مصفوفة: {GC.GetTotalMemory(false)}");

        data = null; // حذف المرجع لجعل المصفوفة غير قابلة للوصول

        Console.WriteLine($"🔹 قبل GC.Collect(): {GC.GetTotalMemory(false)}");
        Console.WriteLine($"🔹 قبل GC.Collect() مع true: {GC.GetTotalMemory(true)}");

        GC.Collect(); // جمع القمامة يدويًا

        Console.WriteLine($"🔹 بعد GC.Collect(): {GC.GetTotalMemory(false)}");
        Console.WriteLine($"🔹 بعد GC.Collect() مع true: {GC.GetTotalMemory(true)}");
    }
}