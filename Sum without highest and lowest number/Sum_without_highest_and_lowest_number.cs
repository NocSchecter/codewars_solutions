using System;
using System.Linq;

public static class Sum_without_highest_and_lowest_number
{  
  public static int Sum(int[] numbers)
  {
    int sum = 0;
    int sumMinMax;
    
    if(numbers == null || numbers.Length == 0 || numbers.Length == 1)
      return 0;
    
    int min = numbers[0], max = numbers[0];
    
    for(int i = 0; i < numbers.Length; i++)
    {
      if(numbers[i] > max)
        max = numbers[i];
      
      else if(numbers[i] < min)
        min = numbers[i];
      
      sum += numbers[i];
    }
    
    sumMinMax = min + max;
    
    return sum - sumMinMax;
  }
}