using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var ip = new IP("123.456.789.111");
        ip[0] = 10;

        Console.WriteLine(ip[0]);
        Console.WriteLine(ip.Print);

    }


}

class IP
{
    private int[] ip = new int[4];

    public int this[int Index]
    {
        get
        {
            return ip[Index];
        }
        set
        {
            ip[Index] = value;
        }
    }

    public IP(string Addres)
    {
        this.ip = Array.ConvertAll(Addres.Split("."), int.Parse);
        ip = Addres.Split(".").Select(int.Parse).ToArray();
    }



    public string Print => string.Join(",", ip);
}