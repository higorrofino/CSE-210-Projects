using System.Security;

public class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public MathAssignment(string name, string topic, string textBook, string prob) : base(name, topic){
    _textbookSection = textBook;
    _problems = prob;
  }

  public string GetHomeworkList(){
    return $"Section {_textbookSection} Problems {_problems}";
  }
}

