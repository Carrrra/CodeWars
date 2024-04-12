using System;

public static class Kata
{
    public static int ElevatorDistance(int[] array) 
    {
        // your code here ..
      int sum = 0;
      int a = 0;
        for(int i = 0; i < array.Length-1; i++) {
          if(array[i] > array[i+1]){
            a = array[i] - array[i+1];
        }else {
          a = array[i + 1] - array[i];
        }
          sum += a;
    }
      return sum;
}
}