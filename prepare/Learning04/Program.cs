using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment ass1 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");

        Console.WriteLine(ass1.GetSummary());
        Console.WriteLine(ass1.GetWritingInformation());
    }
}