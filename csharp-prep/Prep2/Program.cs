using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percentFromUser = Console.ReadLine();

        int percentGrade = int.Parse(percentFromUser);
        string letterGrade = "";

        if (percentGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else if (percentGrade < 60)
        {
            letterGrade = "F";
        }
        else
        {
            Console.WriteLine("Invalid information");
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (percentGrade >= 70)
        {
            Console.WriteLine("Congratulations!! You passed!");
        }
        else
        {
            Console.WriteLine("It was not this time! You not passed");
        }

    }
}