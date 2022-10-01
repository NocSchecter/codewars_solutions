using System;

public static class Summation 
{
    public static int summation(int num)
    {
      int temp = 0;
      
      for(int i = 1; i < num + 1; i++)
        temp = i + temp;
      
      return  temp;
    }
}