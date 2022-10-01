using System;
public class ShortestWord
{
  public static int FindShort(string s)
  {
    string[] temp = s.Split(" ");
    int min = temp[0].Length;
    
    for(int i = 0; i < temp.Length; i++)
    {
      if(temp[i].Length < min)
      {
        min = temp[i].Length;
      }
    }
    return min;
  }
}