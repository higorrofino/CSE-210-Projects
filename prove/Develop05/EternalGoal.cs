public class EternalGoal : Goal
{
  private int _timesCompleted = 0;

  public EternalGoal(string name, string description, int points) : base(name,description,points){}
  
  public override void IsComplete()
  {
    _timesCompleted++;
    Console.WriteLine($"You recorded {_shortName} and earned {_points} points.");
  }

  public override string Progress()
  {
    return $"Completed {_timesCompleted} times";
  }
}