public class SimpleGoal : Goal
{
  protected bool _isComplete = false;

  public SimpleGoal(string name, string description, int points) : base(name,description,points){}
  
  public override void IsComplete()
  {
    if (!_isComplete)
    {
      _isComplete = true;
      Console.WriteLine($"Congratulations! You completed the {_shortName} goal and earned {_points} points");
    }
    else
    {
      Console.WriteLine($"You have already completed the {_shortName} goal");
    }
  }

  public override string Progress()
  {
    return _isComplete? "[X]" : "[ ]";
  }
}