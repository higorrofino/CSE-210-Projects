public class BreathingActivity : Activity{

  public BreathingActivity(string name, string description) : base(name, description){}

  public void Run(){
    DisplaStartingMessage();

    Console.WriteLine("Get ready...");

    ShowSpinner(2);

    DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(_duration);

    do{
    Console.WriteLine();
    Console.Write("Breathe in ...");
    ShowCountDown(4);
    Console.WriteLine();
    Console.Write("Now breathe out ...");
    ShowCountDown(6);
    Console.WriteLine();

    } while (DateTime.Now < futureTime);

    Console.WriteLine();
    DisplaEndingMessage();
    ShowSpinner(3);
    Console.Clear();
  }
}