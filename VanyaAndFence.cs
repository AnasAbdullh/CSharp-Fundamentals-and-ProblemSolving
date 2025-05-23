using System;

public static class Program
{
    public static void Main()
    {
        int numberOfPeople = VanyaAndFence.ReadNumberOfPeople();
        int heightOfFence = VanyaAndFence.ReadHeightLengthFence();

        VanyaAndFence fenceSimulation = new VanyaAndFence(numberOfPeople, heightOfFence);
        fenceSimulation.ReadHeightOfPeople();
        fenceSimulation.CalculateMinimumPossibleRoadWidth();
        fenceSimulation.PrintMinimumSingleLaneCrossing();
    }
}

public class VanyaAndFence
{
    private int _numberOfPeople;
    private int _heightOfFence;
    private int[] _heightOfPeople;
    private int _minimumSingleLaneCrossing = 0;

    public VanyaAndFence(int numberOfPeople, int fenceHeight)
    {
        _numberOfPeople = numberOfPeople;
        _heightOfFence = fenceHeight;
        _heightOfPeople = new int[numberOfPeople];
    }

    public static int ReadNumberOfPeople()
    {
        Console.Write("Please Enter Number Of People: ");
        return ParseAndValidateInput(Console.ReadLine());
    }

    public static int ReadHeightLengthFence()
    {
        Console.Write("Enter the length of the fence height: ");
        return ParseAndValidateInput(Console.ReadLine());
    }

    public void ReadHeightOfPeople()
    {
        for (int i = 0; i < _numberOfPeople; i++)
        {
            Console.Write($"Enter height of person {i + 1}: ");
            _heightOfPeople[i] = ParseAndValidateInput(Console.ReadLine());
        }
    }

    public void CalculateMinimumPossibleRoadWidth()
    {
        foreach (var height in _heightOfPeople)
        {
            if (height <= _heightOfFence)
                _minimumSingleLaneCrossing += 1;
            else
                _minimumSingleLaneCrossing += 2;
        }
    }

    public void PrintMinimumSingleLaneCrossing()
    {
        Console.WriteLine($"The minimum possible valid width of the road: {_minimumSingleLaneCrossing}");
    }

    private static int ParseAndValidateInput(string value)
    {
        int result;
        while (!int.TryParse(value, out result) || result <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
            value = Console.ReadLine();
        }
        return result;
    }
}