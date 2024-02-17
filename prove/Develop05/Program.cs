using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        int points = 0;

        GoalManager manager = new GoalManager();

        do
        {
            Console.WriteLine($"You have {points} points");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();

            switch(user)
            {
                case "1":
                    manager.CreateGoal();
                    break;

                case "2":
                    manager.ListGoal();
                    break;

                case "3":
                    manager.SaveGoals();
                    break;

                case "4":
                    manager.LoadGoals();
                    break;

                case "5":
                    manager.RecordEvent();
                    break;
            }
        } while(user != "6");
    }
}