using System;
using System.Linq;

class Program
{
    static void Main()
    {

        var n = int.Parse(Console.ReadLine());

        var Team = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int Programming = 0, Maths = 0, PE = 0;

        Programming = Team.Count(n => n == 1);
        Maths = Team.Count(n => n == 2);
        PE = Team.Count(n => n == 3);

        int Least = Math.Min(Math.Min(Programming, Maths), PE);

        if (Least == 0)
        {
            Console.WriteLine(Least);
            return;
        }

        var arrProgramming = new int[Programming];
        var arrMaths = new int[Maths];
        var arrPE = new int[PE];

        int IndexProgramming = -1;
        int IndexMaths = -1;
        int IndexPE = -1;

        for (int i = n - 1; i >= 0; i--)
        {
            if (Team[i] == 1)
            {
                IndexProgramming++;
                arrProgramming[IndexProgramming] = i + 1;
            }
            else if (Team[i] == 2)
            {
                IndexMaths++;
                arrMaths[IndexMaths] = i + 1;
            }
            else
            {
                IndexPE++;
                arrPE[IndexPE] = i + 1;
            }
        }


        Console.WriteLine(Least);


        for (int i = Least - 1; i >= 0; i--)
        {
            string v = arrProgramming[i] + " " + arrMaths[i] + " " + arrPE[i];
            Console.WriteLine(v);
        }



    }

}

