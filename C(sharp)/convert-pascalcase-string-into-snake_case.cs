using System;
using System.Linq;

public static class Kata 
{
  public static string ToUnderscore(int str) 
  {
    return str.ToString();
  }

  public static string ToUnderscore(string str) 
  {
    return string.Concat(str.Select(x=>char.IsUpper(x)?"_"+x.ToString().ToLower():x.ToString())).TrimStart('_');
  }
}
