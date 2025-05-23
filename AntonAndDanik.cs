using System;


public static class Program
{
    public static void Main()
    {
        var TheNumberOfTimee = AntonAndDanik.ReadTheNumberOfMatches();
        var TheWinnerIdEveryMatch = AntonAndDanik.ReadTheWinnersletters(TheNumberOfTimee);

        AntonAndDanik Winner = new AntonAndDanik(TheNumberOfTimee, TheWinnerIdEveryMatch);
        Winner.PrintWinner();
    }
}

public class AntonAndDanik
{
    private int _theNumberOfTimes = 0;
    private string _theWinnerIsEveryMatch;
    private string _theFinallyWinner;

    public AntonAndDanik(int TheNumberOfTimes, string TheWinnerIsEveryMatch)
    {
        _theNumberOfTimes = TheNumberOfTimes;
        _theWinnerIsEveryMatch = TheWinnerIsEveryMatch;
        CheckFormWinner();
    }

    public static int ReadTheNumberOfMatches()
    {
        Console.Write("Please Enter Number Of Matches: ");
        return ParseAndValidateInput(Console.ReadLine());
    }


    public static int ParseAndValidateInput(string value)
    {
        int result;
        while (!int.TryParse(value, out result) || result <= 0 || result > 100000)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
            value = Console.ReadLine();
        }
        return result;
    }

    public static string ReadTheWinnersletters(int NumberOfMatches)
    {
        Console.WriteLine("Enter Letter contest:");
        string value = Console.ReadLine().ToUpper();
        while (!DoAllSeriesContainTheseTwoLetters('A', 'D', value) || value.Length != NumberOfMatches)
        {
            Console.WriteLine("Please enter a value that matches the number of matches and contains only 'A' or 'D':");
            value = Console.ReadLine().ToUpper();

           
        }

        return value;
    }

    private static bool DoAllSeriesContainTheseTwoLetters(char FirstLetter, char SecondsLetter, string TheOriginalString)
    {
        foreach (var item in TheOriginalString)
        {
            if (item != FirstLetter && item != SecondsLetter)
            {
                return false;
            }
        }
        return true;
    }

    private void CheckFormWinner()
    {
        int Anton = 0, Danik = 0;

        foreach (var item in _theWinnerIsEveryMatch)
        {
            if (item == 'A')
            {
                Anton++;
            }
            else
            {
                Danik++;
            }
        }

        _theFinallyWinner = Anton == Danik ? "Friendship" : Anton > Danik ? "Anton" : "Danik";
    }

    public void PrintWinner()
    {
        Console.WriteLine($"The Winner In This Game is {_theFinallyWinner}");
    }
}