using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber;

        Console.WriteLine("Please entera series of numbers to comepose the list, to stop just enter the number 0.");

        do
        {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        //SUM
        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        //AVERAGE
        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is {avg}");

        //MAX
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is {max}");
    }
}