public class Sequence 
{
  public static long GetScore(long n) 
  {
    if(n == 0)return n;
    else return GetScore(n-1) + n*50;
  }
}
