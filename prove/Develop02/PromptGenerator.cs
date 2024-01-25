using System;
using System.Collections.Generic;
public class PromptGenerator
{
 public List<string> promptsList = new List<string>();

 public void AddValue(string value)
 {
  promptsList.Add(value);
 }

  public string GetRandomPrompt()
  {
    Random random = new Random();

    int randomIndex = random.Next(promptsList.Count);

    return promptsList[randomIndex];
  }
}