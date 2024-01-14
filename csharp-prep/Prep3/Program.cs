using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your  guess? ");
        string userGuess = Console.ReadLine();

        int guess = int.Parse(userGuess);

        do
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your  guess? ");
            userGuess = Console.ReadLine();

            guess = int.Parse(userGuess);            

        } while(guess != number);

        Console.WriteLine("You guessed it!");
    }
}