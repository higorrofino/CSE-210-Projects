using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        DisplayResult(userName, square);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }
    
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string userNumber = Console.ReadLine();

        int number = int.Parse(userNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"Brother {userName}, the square of your number is {square}");
    }
}