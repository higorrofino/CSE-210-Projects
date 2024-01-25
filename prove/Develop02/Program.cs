using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator promptsadd = new PromptGenerator();
        promptsadd.AddValue("Who was the most interesting person I interacted with today?");
        promptsadd.AddValue("What was the best part of my day?");
        promptsadd.AddValue("How did I see the hand of the Lord in my life today?");
        promptsadd.AddValue("What was the strongest emotion I felt today?");
        promptsadd.AddValue("If I had one thing I could do over today, what would it be?");

        string response;
        Random random = new Random();
        Entry entryadd = new Entry();
        Journal getEntry = new Journal();
        do
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {
                int randomPromptIndex = random.Next(promptsadd.promptsList.Count);
                string selectedPrompt = promptsadd.promptsList[randomPromptIndex];

                entryadd._date = dateText;
                entryadd._promptText = selectedPrompt;
                Console.WriteLine(selectedPrompt);
                entryadd._entryText = Console.ReadLine();

                getEntry.AddEntry(entryadd);
            }
            else if (response == "2")
            {
                getEntry.DisplayAll();
            }
            else if (response == "3")
            {

            }
            else if (response == "4")
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                
                getEntry.SaveToFile(file);
            }

        } while (response != "5");
    }
}