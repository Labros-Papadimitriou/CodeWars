using System;
using System.Text.RegularExpressions;
public class Parentheses
{
    public static bool ValidParentheses(string str)
    {
      str = Regex.Replace(str, @"[^()]", "");
      for (int i = 0; i < str.Length+1; i++)
      {
          str = Regex.Replace(str, @"\(\)", "");
      }
      return str.Length == 0;
    }
}
