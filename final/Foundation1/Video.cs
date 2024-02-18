using System.Runtime.InteropServices;

public class Video
{
  public string _title;
  public string _author;
  public int _length;
  public List<Comment> _comments = new List<Comment>();

  public string NumberOfComment()
  {
    return $"The number of comments for this video is {_comments.Count()}";
  }

  public void Display()
  {
    Console.WriteLine($"\nTitle: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Duration(seconds): {_length}");
    Console.WriteLine($"Comments: {NumberOfComment()}");
    
    foreach(Comment comment in _comments)
    {
      comment.Display();
    }
  }
}