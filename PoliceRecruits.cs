using System;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] PoliceRecruits = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int availableOfficers = 0;
        int untreatedCrimes = 0;

        foreach (var item in PoliceRecruits)
        {
            if (item == -1)
            {
                if (availableOfficers == 0)
                {
                    untreatedCrimes++;
                }
                else
                {
                    availableOfficers--;
                }

            }
            else
            {
                availableOfficers += item;
            }
        }

        Console.WriteLine(untreatedCrimes);



    }

}