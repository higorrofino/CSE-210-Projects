public class Scripture{
  private Reference _reference;
  private List<string> _words;

  public Scripture(Reference reference, string text){
    _reference = reference;
    _words = text.Split(" ").ToList();
  }

  public void HideRandomWords(){
    Random random = new Random();
    int index = random.Next(_words.Count());
    _words[index] = "_ _ _ _";
  }

  // public void Hide(){
  //   _words.Where(word => !word.Equals("_ _ _ _")).ToList();
  // }

  public string GetDisplayText(){
    string parag = string.Join(" ", _words);
    return parag;
  }

  public bool IsCompletelyHidden(){
    return _words.All(w => w.Equals("_ _ _ _"));
  }
}