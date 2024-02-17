using System.Runtime;

public class ChecklistGoal : Goal
{
  private int _timesCompleted;
  private int _target;

  public ChecklistGoal(string name, string description, int points, int target) : base(name,description,points)
  {
    _target = target;
  }

  public override void IsComplete()
  {
    _timesCompleted++;
    Console.WriteLine($"You recorded {_shortName} ({_timesCompleted}/{_target}) and earned {_points} points.");

    if (_timesCompleted == _target)
    {
      Console.WriteLine($"Congratulations! You completed the {_shortName} goal and earned a bonus of {_points * 2} points");
    }
  }

  public override string Progress()
    {
        return $"Completed {_timesCompleted}/{_target} times";
    }
}