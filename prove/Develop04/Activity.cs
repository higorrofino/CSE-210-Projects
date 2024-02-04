public class Activity{
  private string _name;
  private string _description;
  public int _duration;

  public Activity(string name, string description){
    _name = name;
    _description = description;
  }

  public void DisplaStartingMessage(){
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();

    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    Console.Clear();
  }

  public void DisplaEndingMessage(){
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    ShowSpinner(3);

    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

  }

  public void ShowSpinner(int seconds){
    for (int i = seconds; i > 0; i--){
      Console.Write("|");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("/");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("-");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("\\");
      Thread.Sleep(250);
      Console.Write("\b \b");
    }
  }

  public void ShowCountDown(int seconds){
    for (int i = seconds; i > 0; i--){
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}