using System;

public static class Kata 
{
  public static int TrailingZeros(int n, int sum=0)
  {
    int numOfZeroes = 0;
    while (n != 0)
    {
      numOfZeroes += (int)Math.Floor((double)n/5);
      n /= 5;
    }
    return numOfZeroes;
  }
}
