using System.IO.Compression;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity(string name, string description) : base(name, description){}

  public void Run(){
    _prompts = new List<string>();
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _questions = new List<string>();
    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");

    DisplaStartingMessage();

    Console.WriteLine("Get ready...");
    ShowSpinner(2);

    Console.WriteLine();
    Console.WriteLine("Consider the following prompt");

    Console.WriteLine();
    Console.WriteLine("---- " + GetRandomPrompt() + " ----");

    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();

    DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(_duration);
    do{
      Console.Write("> " + GetRandomQuestion());
      ShowSpinner(7);
      Console.WriteLine();
      } while (DateTime.Now < futureTime);

      DisplaEndingMessage();
  }

  public string GetRandomPrompt(){
    Random random = new Random();
    int index = random.Next(_prompts.Count());
    return _prompts[index];
  }
  
  public string GetRandomQuestion(){
    Random random = new Random();
    int index = random.Next(_questions.Count());
    return _questions[index];
  }

  public void DisplayPrompt(){}

  public void DisplayQuestion(){}
}