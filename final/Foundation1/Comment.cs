public class Comment
{
  public string _name;
  public string _textComment;

  public void Display()
  {
    Console.WriteLine($"{_name} -> '{_textComment}'");
  }
}