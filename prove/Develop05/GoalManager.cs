public class GoalManager
{
  private List<string> _goals = new List<string>();
  private int _score;

  public GoalManager(){}

  public void CreateGoal()
  {
    Console.WriteLine("\nChoose the type of goal:");
    Console.WriteLine("1. Simple goal");
    Console.WriteLine("2. Eternal goal");
    Console.WriteLine("3. Checklist goal");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    Console.Write("Enter goal name: ");
    string name = Console.ReadLine();

    Console.Write("Enter goal description: ");
    string description = Console.ReadLine();

    Console.Write("Enter points for completing the goal: ");
    int points = int.Parse(Console.ReadLine());

    switch(choice)
    {
      case "1":
        _goals.Add($"Simple Goal - {name}: {description} ({points} points)");
        break;
      
      case "2":
        _goals.Add($"Eternal Goal - {name}: {description} ({points} points)");
        break;
      
      case "3":
        Console.Write("Enter target completion count: ");
        int target = int.Parse(Console.ReadLine());
        _goals.Add($"Simple Goal - {name}: {description} ({points} points, target: {target})");
        break;
      
      default:
        Console.WriteLine("Invalid Option.");
        break;
    }
  }
  
  public void ListGoal()
  {
    Console.WriteLine("\nList of Goals:");
    foreach(var goal in _goals)
    {
      Console.WriteLine($"{goal}");
    }
  }

  public void SaveGoals()
  {
    Console.Write("Enter the file name: ");
    string file = Console.ReadLine();
    using (StreamWriter sw = new StreamWriter(file))
    {
      foreach(var goal in _goals)
      {
        string line = $"{goal}";

        sw.WriteLine(line);
      }
    }
  }
  
  public void LoadGoals()
  {
    Console.Write("Enter the file name: ");
    string file = Console.ReadLine();

    if(File.Exists(file))
    {
      using(StreamReader sr = new StreamReader(file))
      {
        string line;
        while((line = sr.ReadLine()) != null)
        {
          _goals.Add(line);
        }
      }
    }
  }

  public void RecordEvent()
  {
    Console.WriteLine("\nChoose the goal to completed: ");

    for(int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i]}");
    }

    Console.Write("Enter goal number: ");
    int goalIndex = int.Parse(Console.ReadLine()) - 1;
  }
}