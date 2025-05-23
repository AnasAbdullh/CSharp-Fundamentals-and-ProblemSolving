using System;
using System.Collections;

class InvalidAgeException : Exception
{
    public string CustomMessage; // متغير جديد لتخزين الرسالة

    public InvalidAgeException(string message)
    {
        CustomMessage = message; // تخزين الرسالة داخل متغير جديد بدلاً من `base`
    }

    public override string Message
    {
        get
        {
            return CustomMessage;
        }
    }

}

class Program
{
    static void Main()
    {
        try
        {
            throw new InvalidAgeException("العمر غير مسموح!");
        }
        catch (InvalidAgeException ex) // نوع الكاتش يطابق الاستثناء
        {
            // throw ex;

        }
        Console.WriteLine(7.GetHashCode());

        int[] Yen = new[] { 1, 2, 3, 4 };

        //Console.WriteLine("t");

        var e1 = new MyClass();
        var e2 = new MyClass();
        var e3 = e2;

        Console.WriteLine(e2.GetHashCode());
        Console.WriteLine(e3.GetHashCode());

        var s = "Anas";
        var i = "Anas";

        Console.WriteLine(e1 == e2);
        Console.WriteLine(s is MyClass);

        Console.WriteLine(e1 is string);

        object obj = new MyClass();



        // التحويل باستخدام as
        MyClass obj1 = obj as MyClass;
        Console.WriteLine(obj1 == null ? "❌ التحويل فشل" : "✅ التحويل ناجح");

        // التحويل باستخدام (Type)
        try
        {
            MyClass obj2 = (MyClass)obj; // سيرمي استثناء إذا لم يكن التحويل ممكنًا
            Console.WriteLine("✅ التحويل ناجح");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("❌ التحويل فشل بسبب استثناء!");
        }

        Animal myAnimal = new Dog(); // ✅ Upcasting صحيح
        Dog myDog = (Dog)myAnimal; // ❌ سيعيد `null` لأن `myAnimal` ليس `Dog`

        if (myDog != null)
            Console.WriteLine("✅ التحويل ناجح!");
        else
            Console.WriteLine("❌ التحويل فشل.");

        MyClass My = new MyClass();
        object ob = My;
        var emp = ob as MyClass;


        ParentClass parent = new ParentClass { Value = 10 };
        ChildClass child = new ChildClass { Value = 10 };

        // ستستخدم GetHashCode من الكلاس الأب
        Console.WriteLine(parent.GetHashCode());  // سيطبع الـ hash بناءً على Value في الكلاس الأب
        Console.WriteLine(child.GetHashCode());   // سيطبع الـ hash بناءً على Value في الكلاس الأب، لأننا لم نعد تعريف GetHashCode في الابن


        var Sure = new Anas();
        foreach (var item in Sure)
        {
            Console.WriteLine(item);
        }




    }



}

class MyClass
{
    public int Anime { get; set; }
}

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

class Anas : IEnumerable
{
    int[] Numbers = new[] { 1, 2, 3, 4, 5 };
    public IEnumerator GetEnumerator()
    {
        foreach (var item in Numbers)
        {
            yield return item;
        }
    }
}


class ParentClass
{
    public int Value { get; set; }

    // دالة GetHashCode في الكلاس الأب
    public override int GetHashCode()
    {
        return Value.GetHashCode();  // فقط نستخدم قيمة الـ Value لحساب الـ hash
    }

    // دالة Equals في الكلاس الأب
    public override bool Equals(object obj)
    {
        if (obj is ParentClass other)
        {
            return this.Value == other.Value;
        }
        return false;
    }
}

class ChildClass : ParentClass
{
    // دالة Equals في الكلاس الابن
    public override bool Equals(object obj)
    {
        if (obj is ChildClass other)
        {
            return this.Value == other.Value;
        }
        return false;
    }
}



using System;
using System.Collections.Generic;

public class Temperature : IComparable<Temperature>
{
    public int Value { get; set; }

    public Temperature(int value)
    {
        Value = value;
    }

    // تنفيذ دالة CompareTo لترتيب القيم
    public int CompareTo(Temperature other)
    {
        if (other == null)
            return 1;

        return this.Value.CompareTo(other.Value);
    }

    // إعادة تعريف دالة ToString لعرض القيم عند الطباعة
    public override string ToString()
    {
        return $"{Value}°C";
    }
}

class Program
{
    static void Main()
    {
        var temps = new List<Temperature>();
        Random rnd = new Random();

        // إضافة 100 درجة حرارة عشوائية من -30 إلى 50
        for (var i = 0; i < 100; i++)
        {
            temps.Add(new Temperature(rnd.Next(-30, 50)));
        }

        // ترتيب العناصر باستخدام الدالة CompareTo
        temps.Sort();

        // طباعة جميع العناصر بعد الترتيب
        foreach (var item in temps)
        {
            Console.WriteLine(item);
        }
    }
}
