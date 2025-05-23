using System;


class Program
{

    public static void Main()
    {

        double i = 123.4;
        int v = (int)i;


        // boxing And unboxing
        // boxing convert Datatype to refrence
        // unboxing convert refernce to datatype


        object o;
        int x = 3;

        o = x;

        int y = (int)o;
        ++x;
        Console.Write(o);


        string value = "t123";
        //int f = (int)value;

        int z = 1234;
        string c = z.ToString();

        Console.WriteLine(c);

        Console.WriteLine("999999999999999999");

        if (int.TryParse(value, out int Value))
        {
            Console.WriteLine(Value);
        }
        else
        {
            Console.WriteLine("does not a invalid value");
        }

        //var d = Convert.ToInt32(value);
        Decimal hh = 1;
        Console.WriteLine(Decimal.MaxValue);


        int Number = 255;

        var Bytes = BitConverter.GetBytes(Number);

        foreach (var t in Bytes)
        {
            // Console.WriteLine(t);
            var binray = Convert.ToString(t, 2).PadLeft(8, '0');
            Console.WriteLine(binray);
        }


        var Name = "Anas";

        char[] Letters = Name.ToCharArray();

        foreach (var t in Name)
        {
            int Chrat = Convert.ToInt32(t);
            var Output = $"{t} {Chrat} {Convert.ToString(t, 2).PadLeft(8, '0')} {Chrat:x}";
            Console.WriteLine(Output);
        }



        string[] charcters = { "41", "6e", "61", "73" };


        foreach (var q in charcters)
        {
            //Console.WriteLine(Convert.ToInt32(q, 16));
            var value = Convert.ToInt32(q, 16);
            //Console.WriteLine(char.ConvertFromUtf32(Convert.ToInt32(q, 16)));

            char s = (char)value;
            Console.WriteLine((char)Convert.ToInt32(q, 16));

        }

        // BitConvertor



        var hex = "8E2";


        int number = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine(number);


    }

}
