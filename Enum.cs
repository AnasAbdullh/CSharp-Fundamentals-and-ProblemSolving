using System;

class Program
{
    static void Main()
    {

        Console.WriteLine(DAY.FRIDAY.GetHashCode());
        Console.WriteLine(DAY.FRIDAY.HasFlag(DAY.FRIDAY));

        var i = DAY.THURSDAY | DAY.TUESDAY;
        Console.WriteLine((int)i);
        if (i.HasFlag(DAY.TUESDAY))
        {
            Console.WriteLine(true);
        }

        int c = 110;
        Console.WriteLine("h");

        foreach (var item in Enum.GetNames(typeof(DAY)))
        {
            Console.WriteLine($"{item} = {(int)Enum.Parse(typeof(DAY), item)}");
        }

        foreach (var item in Enum.GetValues(typeof(DAY)))
        {
            Console.WriteLine((int)item);
        }

        if (Enum.IsDefined(typeof(DAY), 2))
        {

        }


    }




    [Flags]
    enum DAY
    {


        NONE = 0b_0000_0000,

        MONDAY = 0b_0000_0001,

        TUESDAY = 0b_0000_0010,

        WEDNESDAY = 0b_0000_0100,

        THURSDAY = 0b_0000_1000,

        FRIDAY = 0b_0001_0000,

        SATURDAY = 0b_0010_0000,

    }

    public enum DayOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }


}

