using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // عدد الأسلاك
        int[] birds = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // عدد الطيور على كل سلك

        int m = int.Parse(Console.ReadLine()); // عدد الطلقات

        for (int i = 0; i < m; i++)
        {
            string[] shot = Console.ReadLine().Split(); // عدد الطيور على كل سلك

            int x = int.Parse(shot[0]) - 1;
            int y = int.Parse(shot[1]);

            int LeftBirds = y - 1;
            int RigthBirds = birds[x] - y;

            if (x > 0) birds[x - 1] += LeftBirds;
            if (x < n - 1) birds[x + 1] += RigthBirds;

            birds[x] = 0;

        }

        foreach (var item in birds)
        {
            Console.WriteLine(item);
        }
    }
}
