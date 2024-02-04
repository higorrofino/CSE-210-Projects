public class ListingActivity : Activity{

  private int _count;
  private List<string> _prompts;

  public ListingActivity(string name, string description) : base(name, description){}

  public void Run(){
    _count = 0;

    _prompts = new List<string>();
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");

    DisplaStartingMessage();

    Console.WriteLine("Get ready...");
    ShowSpinner(2);

    DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(_duration);
      Console.WriteLine();
      Console.WriteLine("List as many responses you can to the following prompt:");
      GetRandomPrompt();
      Console.WriteLine("You may begin in:");
      do{
        Console.Write("> ");
        string r1 = Console.ReadLine();
        _count += 1;
      } while(DateTime.Now < futureTime);
      Console.WriteLine($"You listed {_count} itens!");

      DisplaEndingMessage();
  }

  public void GetRandomPrompt(){
    Random random = new Random();
    int index = random.Next(_prompts.Count());
    Console.WriteLine($"  ---- {_prompts[index]} ----");
  }

  public List<string> GetListFromUser(){
    return _prompts;
  }
}