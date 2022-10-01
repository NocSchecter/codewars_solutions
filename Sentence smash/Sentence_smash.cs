using System;
public class Sentence_smash
{
  public static string Smash(string[] words)
  {
    string sentence = "";
    char[] charsToTrim = {' '};
    string result = "";
      
    for(int i = 0; i < words.Length; i++)
    {
      sentence = sentence + " " + words[i];
    }
    
    result = sentence.Trim(charsToTrim);
    
    return result;
  }
}