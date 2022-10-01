using System;

public static class Return_negative
{
  public static int MakeNegative(int number)
  {
    if(number > 0)
      {
        number = number * -1;
      }
    else if(number < 0)
      {
        number = number;
      }
    
    return number;
  }
}