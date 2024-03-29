using System;

class Program
{
    static void Main(string[] args)
    {
        string userOption;
        do{
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = Console.ReadLine();

            if (userOption == "1"){
                BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                activity.Run();
            } 
            
            else if (userOption == "2"){
                ReflectingActivity activity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                activity.Run();
            }

            else if (userOption == "3"){
                ListingActivity activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                
                activity.Run();
            }
        }while (userOption != "4");
    }
}