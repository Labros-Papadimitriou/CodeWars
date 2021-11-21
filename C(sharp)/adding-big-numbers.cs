using System;
using System.Numerics;

public class Kata
{
  public static string Add(string a, string b)
  {
    BigInteger int1 = BigInteger.Parse(a);
    BigInteger int2 = BigInteger.Parse(b);
    return (int1 + int2).ToString();
  }
}
